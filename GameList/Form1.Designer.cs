namespace GameList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_finish = new System.Windows.Forms.Label();
            this.lbl_planned = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_finished = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_finishCount = new System.Windows.Forms.Label();
            this.listBoxP = new System.Windows.Forms.ListBox();
            this.listBoxF = new System.Windows.Forms.ListBox();
            this.btn_unfinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_finish
            // 
            this.lbl_finish.AutoSize = true;
            this.lbl_finish.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finish.Location = new System.Drawing.Point(332, 9);
            this.lbl_finish.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.lbl_finish.Name = "lbl_finish";
            this.lbl_finish.Size = new System.Drawing.Size(144, 25);
            this.lbl_finish.TabIndex = 1;
            this.lbl_finish.Text = "Finished Games";
            // 
            // lbl_planned
            // 
            this.lbl_planned.AutoSize = true;
            this.lbl_planned.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planned.Location = new System.Drawing.Point(9, 9);
            this.lbl_planned.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_planned.Name = "lbl_planned";
            this.lbl_planned.Size = new System.Drawing.Size(143, 25);
            this.lbl_planned.TabIndex = 5;
            this.lbl_planned.Text = "Planned Games";
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove.Location = new System.Drawing.Point(174, 566);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_finished
            // 
            this.btn_finished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_finished.Location = new System.Drawing.Point(93, 566);
            this.btn_finished.Name = "btn_finished";
            this.btn_finished.Size = new System.Drawing.Size(75, 23);
            this.btn_finished.TabIndex = 4;
            this.btn_finished.Text = "Finished";
            this.btn_finished.UseVisualStyleBackColor = true;
            this.btn_finished.Click += new System.EventHandler(this.btn_finished_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Location = new System.Drawing.Point(12, 566);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Game";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_finishCount
            // 
            this.lbl_finishCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_finishCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finishCount.Location = new System.Drawing.Point(450, 566);
            this.lbl_finishCount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lbl_finishCount.Name = "lbl_finishCount";
            this.lbl_finishCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_finishCount.Size = new System.Drawing.Size(202, 23);
            this.lbl_finishCount.TabIndex = 9;
            this.lbl_finishCount.Text = "-/- Games Completed";
            this.lbl_finishCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // listBoxP
            // 
            this.listBoxP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxP.FormattingEnabled = true;
            this.listBoxP.ItemHeight = 17;
            this.listBoxP.Location = new System.Drawing.Point(12, 40);
            this.listBoxP.Name = "listBoxP";
            this.listBoxP.Size = new System.Drawing.Size(318, 514);
            this.listBoxP.TabIndex = 1;
            // 
            // listBoxF
            // 
            this.listBoxF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxF.FormattingEnabled = true;
            this.listBoxF.ItemHeight = 17;
            this.listBoxF.Location = new System.Drawing.Point(336, 40);
            this.listBoxF.Name = "listBoxF";
            this.listBoxF.Size = new System.Drawing.Size(316, 514);
            this.listBoxF.TabIndex = 2;
            // 
            // btn_unfinish
            // 
            this.btn_unfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_unfinish.Location = new System.Drawing.Point(336, 566);
            this.btn_unfinish.Name = "btn_unfinish";
            this.btn_unfinish.Size = new System.Drawing.Size(75, 23);
            this.btn_unfinish.TabIndex = 6;
            this.btn_unfinish.Text = "Unfinish";
            this.btn_unfinish.UseVisualStyleBackColor = true;
            this.btn_unfinish.Click += new System.EventHandler(this.btn_unfinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 601);
            this.Controls.Add(this.btn_unfinish);
            this.Controls.Add(this.listBoxF);
            this.Controls.Add(this.listBoxP);
            this.Controls.Add(this.lbl_finishCount);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_finished);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_planned);
            this.Controls.Add(this.lbl_finish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "Game Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.LoadFromFile);
            this.Resize += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_finish;
        private System.Windows.Forms.Label lbl_planned;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_finished;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_finishCount;
        private System.Windows.Forms.ListBox listBoxP;
        private System.Windows.Forms.ListBox listBoxF;
        private System.Windows.Forms.Button btn_unfinish;
    }
}

