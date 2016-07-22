using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameList
{
    public partial class AddGame : Form
    {
        public string gameText { get; set; }

        public AddGame()
        {
            InitializeComponent();
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gameText = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinishUp();
        }

        private void FinishUp()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FinishUp();
            }
        }
    }
}

//⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢰⣶⣶⢀⣴⣄
//⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢸⣿⣿⣿⠟⠋
//⠂⠂⠂⠂⢀⣀⡀⠂⠂⠂⠂⢀⣠⣤⣴⣿⣧⢸⣿⣿⣷⣄⡀
//⢠⣶⣶⡆⣿⣿⣧⠂⣤⣶⣦⡘⣿⣿⣿⣿⣿⠂⣿⣿⠻⡿⠁⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⣀⡀⠂⠂⠂⠂⡠⠔⠒⠒⠒⠒⠒⠤⢄⡀
//⠈⣿⣿⣧⣼⣿⣿⢸⣿⡉⣻⣷⠹⣿⠿⠿⠟⠂⠛⠋⠂⠂⠂⠂⠂⠂⣴⣶⠇⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢠⢃⢻⣷⡤⣀⠊⠂⠂⠂⠂⠂⠂⠂⠂⠂⠈⠐⢤⣄⡀
//⠂⢻⣿⣿⡟⢻⣿⡇⠙⠿⠟⠃⣀⣀⠂⠂⠂⠂⠂⠂⠂⠂⢀⣀⣀⠂⣿⣿⣴⣾⠇⠂⠂⠂⠂⠂⠂⠂⠂⡎⣠⣙⡿⡿⠂⠂⡀⠂⠂⠂⠂⠂⠂⠂⣠⣶⣿⡿⠋⢱
//⠂⠸⣿⣿⣷⠘⠟⠋⢰⣶⡆⢸⣿⣿⠂⠂⣠⣤⣄⠂⣶⣿⣿⣿⣿⢠⣿⣿⣯⡀⠂⠂⠂⠂⠂⠂⠂⢀⡤⠛⠉⠂⠂⠘⠦⠟⠳⣤⢀⠝⠛⣆⣀⠜⠙⠻⣏⣡⠊⡸⠈⢢
//⠂⠂⠈⠂⠂⠂⠂⠂⢸⣿⣧⣼⣿⣿⠂⣼⣿⠛⣿⣷⢿⣿⣿⣿⡇⢸⣿⠛⢿⡿⠂⠂⠂⠂⠂⠂⣴⡱⠆⠂⠂⣠⠦⢴⢿⠂⠂⠂⣿⡤⠒⠦⣄⠂⠂⠂⠈⡎⣰⠃⠂⢀⡇
//⠂⠂⠂⠂⠂⠂⠂⠂⢸⣿⡿⠿⣿⣿⠂⠹⣿⣶⡿⠋⠈⠋⠉⠉⠁⠈⠉⠂⠂⠁⠂⠂⠂⠂⠂⡼⢋⣠⡄⠂⠂⠁⡰⠃⢸⠂⢠⣰⠁⠱⡀⠂⠈⢺⡀⠂⠂⢈⠁⣀⠂⠜⡆
//⠂⠂⠂⠂⠂⠂⠂⠂⢸⣿⣷⠂⣿⠿⠂⠂⠂⠂⠂⠂⣀⣠⡤⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠘⠋⠁⢸⠂⠂⡇⡾⠶⣶⡝⡄⢸⡞⡨⠖⢒⣦⡄⠂⡇⠂⠂⠈⠙⠉⢲⠉
//⠂⠂⠂⠂⠂⠂⠂⠂⠈⠋⠉⠂⠂⠂⠂⠂⢀⣤⣤⠂⣿⣿⣁⣴⡆⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⡎⠐⢨⣧⠂⢀⣼⡇⠘⢼⣧⡇⠂⠂⣿⡏⠈⡇⠂⠂⠂⠂⡠⢸
//⠂⠂⠂⠂⠂⠂⣿⣿⣿⣷⠂⠂⠂⠂⢀⣤⣸⣿⣿⢠⣿⣿⣿⠛⠁⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢀⠇⠇⣸⣿⣿⣿⣿⡇⠂⠂⣿⣷⣶⣿⣿⣿⠂⡇⠂⡀⠐⠁⠂⢸
//⠂⠂⢶⣾⣿⡀⢸⣿⣿⣿⠂⣠⣤⣤⢹⣿⣿⣿⣿⢸⣿⡿⣿⣿⠆⠂⠂⠂⣀⠂⠂⢀⡀⠂⠂⠂⢸⢩⢂⡏⠟⠿⡿⡻⠁⠂⠂⢿⢿⣿⡿⢻⠇⢸⠂⠊⢀⡇⠂⠁⡜
//⠂⠂⠈⢿⣿⣿⣿⣿⣿⣿⡆⣿⣭⣿⠇⢿⡿⠿⠿⠘⠛⠁⢀⠉⠂⠂⠂⢼⠟⣉⣭⣲⣬⡂⠂⠂⠘⣴⢿⠂⠂⠂⠂⠂⠂⠂⠂⠂⠁⠂⠂⠈⠂⡾⠂⠂⣼⠁⡀⡸⠁
//⠂⠂⠂⠈⢿⣿⣿⡀⢿⣿⣿⠈⠉⠁⠂⠂⠂⠂⠂⠂⠂⢸⣿⣴⡦⠂⠂⡎⠂⣼⣿⣿⡇⣙⠦⣠⢖⠋⠙⠳⣦⣀⠂⠂⠂⠂⠊⠓⠚⠁⠂⠂⢰⢃⠔⣱⣇⠴⠟⠁
//⠂⠂⠂⠂⠈⢿⣿⣿⠌⠋⠂⠂⣀⡀⠂⠂⠂⢀⣤⣴⣦⠘⣿⣿⣅⡀⠂⡇⢸⣿⣿⣿⡇⠁⠂⠂⣿⠒⢓⠆⢘⡏⠙⡗⠶⢦⠤⣤⣤⡤⠖⠚⠻⢾⠊⠉⠣⡀⠂⠂⣌⣡⢰⢢
//⠂⠂⠂⠂⠂⠂⠉⠂⢀⣤⣶⢸⣿⣧⠂⢀⣤⡘⣿⣿⣿⡆⢿⣿⠿⠁⠂⢳⡈⠻⠿⢿⣇⠤⠴⢾⣷⣶⣾⣛⣛⣓⣚⡓⠒⠛⠶⠴⡏⠂⠂⠂⢀⣤⣷⣶⡆⢱⠂⠂⣿⡏⣸⡿
//⠂⠂⠂⠂⠂⠂⠂⠂⠂⢿⣿⣆⣿⣿⡄⣿⣯⣿⠻⠿⠋⠁⠈⠁⠂⠂⠂⠂⠈⣑⣺⠍⠑⠂⠂⠂⠳⣌⣉⣁⡞⠂⠂⡟⠽⠛⠛⠒⠿⢦⣤⢤⢼⣻⢿⠿⠇⢸⠂⢠⣿⢧⣿⠃
//⠂⠂⠂⠂⠂⠂⠂⠂⠂⠘⣿⣿⠛⣿⣧⠈⠉⠁⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⣸⠂⠂⣸⠃⠂⠂⠂⠂⠂⠂⠉⠛⠳⠶⠥⢤⠐⠋⣠⣿⣿⣿⠋
//⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢹⣿⠆⠘⠉⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⢀⢴⠇⠂⢀⠏⠂⠲⠒⠖⠢⠰⠤⠦⢦⠥⠈⠄⠘⢦⡚⠻⡿⠟⠁
//⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠁⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⠂⡼⡾⠂⠂⣼⠓⠢⠦⠤⠤⠠⠂⠰⠊⠁⠊⠂⠡⠾⠋⠂⢀⠇


