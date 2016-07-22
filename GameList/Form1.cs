using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameList
{
    public partial class Form1 : Form
    {
        public const char Separator = ((char)007);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var form = new AddGame())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.gameText != null)
                    {
                        listBoxP.Items.Add(form.gameText);
                    }
                }
            }
            updateGameCount();
        }

        public void updateGameCount()
        {
            var num = listBoxP.Items.Count + listBoxF.Items.Count;
            lbl_finishCount.Text = listBoxF.Items.Count.ToString() + "/" + num.ToString() + " Games Completed";
        }

        private void btn_finished_Click(object sender, EventArgs e)
        {
            if (listBoxP.SelectedIndex == -1)
            {
                MessageBox.Show("To finish a game select it then press the \"Finished\" button.");
                return;
            }
            listBoxF.Items.Add(listBoxP.Items[listBoxP.SelectedIndex]);
            listBoxP.Items.RemoveAt(listBoxP.SelectedIndex);
            updateGameCount();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listBoxP.SelectedIndex == -1)
            {
                MessageBox.Show("To remove a game select it then press the \"Remove\" button.");
                return;
            }
            listBoxP.Items.RemoveAt(listBoxP.SelectedIndex);
            updateGameCount();
        }

        private void btn_unfinish_Click(object sender, EventArgs e)
        {
            if (listBoxF.SelectedIndex == -1)
            {
                MessageBox.Show("To undo the finishing of a game select it then press the \"Unfinish\" button.");
                return;
            }
            listBoxP.Items.Add(listBoxF.Items[listBoxF.SelectedIndex]);
            listBoxF.Items.RemoveAt(listBoxF.SelectedIndex);
            updateGameCount();
        }

        private void SaveToFile()
        {
            using (StreamWriter streamWriter = new StreamWriter("GameList.txt"))
            {
                string output = "";
                int count = 0;
                foreach (var i in listBoxP.Items)
                {
                    if (count != listBoxP.Items.Count - 1)
                    {
                        output += i.ToString() + Separator;
                    }
                    else
                    {
                        output += i.ToString();
                    }
                    count += 1;
                }
                output += "\0";
                count = 0;
                foreach (var i in listBoxF.Items)
                {
                    if (count != listBoxF.Items.Count - 1)
                    {
                        output += i.ToString() + Separator;
                    }
                    else
                    {
                        output += i.ToString();
                    }
                    count += 1;
                }
                output += "\0";
                output += this.Width;
                output += Separator;
                output += this.Height;
                streamWriter.WriteLine(output);
            }
        }

        private void LoadFromFile(object sender, EventArgs e)
        {
            using (StreamReader streamReader = new StreamReader("GameList.txt"))
            {
                //calc
                var input = streamReader.ReadLine();
                string[] Array1 = input.Split('\0');
                string[] ArrayP = Array1[0].Split(Separator);
                string[] ArrayF = Array1[1].Split(Separator);
                string[] ArraySize = Array1[2].Split(Separator);
                var ArrayP2 = ArrayP.ToList();
                ArrayP2.Sort();
                var ArrayF2 = ArrayF.ToList();
                ArrayF2.Sort();
                //clear
                listBoxP.Items.Clear();
                listBoxF.Items.Clear();

                // write new
                foreach (var i in ArrayP2)
                {
                    listBoxP.Items.Add(i);
                }
                foreach (var i in ArrayF2)
                {
                    listBoxF.Items.Add(i);
                }

                //Read old size settings
                this.Width = int.Parse( ArraySize[0] );
                this.Height = int.Parse(ArraySize[1]);
                Form1_ResizeEnd(sender, e);

            }
            updateGameCount();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //width and x positioning
            int fullWidth = this.Width;
            int boxWidth = (this.Width - 47)/2;
            listBoxP.Width = boxWidth;
            listBoxF.Width = boxWidth;
            listBoxF.Left = 20 + listBoxP.Width;
            lbl_finish.Left = listBoxF.Left;
            btn_unfinish.Left = listBoxF.Left;
            //Height of boxes
            int boxHeight = this.Height - 115;
            listBoxP.Height = boxHeight;
            listBoxF.Height = boxHeight;
        }
    }
}
