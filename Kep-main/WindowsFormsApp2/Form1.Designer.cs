namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.back = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxNameSrh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDelID = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.searchBName = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUpd = new System.Windows.Forms.TextBox();
            this.upd = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.RosyBrown;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(907, 469);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 30);
            this.back.TabIndex = 18;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(960, 139);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // textBoxNameSrh
            // 
            this.textBoxNameSrh.BackColor = System.Drawing.Color.White;
            this.textBoxNameSrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSrh.Location = new System.Drawing.Point(101, 60);
            this.textBoxNameSrh.Name = "textBoxNameSrh";
            this.textBoxNameSrh.Size = new System.Drawing.Size(151, 26);
            this.textBoxNameSrh.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Request ID:";
            // 
            // textBoxDelID
            // 
            this.textBoxDelID.BackColor = System.Drawing.Color.White;
            this.textBoxDelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDelID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDelID.Location = new System.Drawing.Point(133, 57);
            this.textBoxDelID.Name = "textBoxDelID";
            this.textBoxDelID.Size = new System.Drawing.Size(122, 26);
            this.textBoxDelID.TabIndex = 24;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(180, 89);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 25);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // searchBName
            // 
            this.searchBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBName.ForeColor = System.Drawing.Color.White;
            this.searchBName.Location = new System.Drawing.Point(177, 95);
            this.searchBName.Name = "searchBName";
            this.searchBName.Size = new System.Drawing.Size(75, 25);
            this.searchBName.TabIndex = 22;
            this.searchBName.Text = "Search";
            this.searchBName.UseVisualStyleBackColor = false;
            this.searchBName.Click += new System.EventHandler(this.searchBName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxDelID);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Location = new System.Drawing.Point(12, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 150);
            this.panel1.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(62, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Delete request by ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxNameSrh);
            this.panel2.Controls.Add(this.searchBName);
            this.panel2.Location = new System.Drawing.Point(682, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 150);
            this.panel2.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(33, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Search request by Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(35, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.richTextBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBoxUpd);
            this.panel3.Controls.Add(this.upd);
            this.panel3.Location = new System.Drawing.Point(317, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 268);
            this.panel3.TabIndex = 29;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(59, 60);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(230, 94);
            this.richTextBox2.TabIndex = 31;
            this.richTextBox2.Text = "Εισάγετε το ID της αίτησησς που θέλετε να επεξεργαστείται και στην συνέχεια βάλτε" +
    " υτο νέο όνομα";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(116, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(55, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Request ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(121, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "Update request";
            // 
            // textBoxUpd
            // 
            this.textBoxUpd.BackColor = System.Drawing.Color.White;
            this.textBoxUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpd.Location = new System.Drawing.Point(156, 166);
            this.textBoxUpd.Name = "textBoxUpd";
            this.textBoxUpd.Size = new System.Drawing.Size(133, 26);
            this.textBoxUpd.TabIndex = 24;
            // 
            // upd
            // 
            this.upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.upd.ForeColor = System.Drawing.Color.White;
            this.upd.Location = new System.Drawing.Point(214, 230);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 25);
            this.upd.TabIndex = 23;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(814, 177);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(158, 35);
            this.show.TabIndex = 30;
            this.show.Text = "Show all requests";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(12, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(56, 20);
            this.date.TabIndex = 31;
            this.date.Text = "DATE";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(862, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(51, 20);
            this.time.TabIndex = 32;
            this.time.Text = "TIME";
            // 
            // setTime
            // 
            this.setTime.Enabled = true;
            this.setTime.Tick += new System.EventHandler(this.setTime_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.show);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.back);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit requests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxNameSrh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDelID;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button searchBName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUpd;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer setTime;
    }
}

