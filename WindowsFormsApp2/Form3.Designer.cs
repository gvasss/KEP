namespace WindowsFormsApp2
{
    partial class Form3
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
            this.add = new System.Windows.Forms.Panel();
            this.bdPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.Timer(this.components);
            this.add.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gray;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.Controls.Add(this.bdPicker);
            this.add.Controls.Add(this.label8);
            this.add.Controls.Add(this.label6);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.textBox6);
            this.add.Controls.Add(this.textBox5);
            this.add.Controls.Add(this.textBox3);
            this.add.Controls.Add(this.textBox2);
            this.add.Controls.Add(this.textBox1);
            this.add.Controls.Add(this.insert);
            this.add.Location = new System.Drawing.Point(295, 106);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(418, 296);
            this.add.TabIndex = 21;
            // 
            // bdPicker
            // 
            this.bdPicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bdPicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.bdPicker.CalendarTitleBackColor = System.Drawing.Color.NavajoWhite;
            this.bdPicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bdPicker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bdPicker.CustomFormat = "dd/MM/yyyy";
            this.bdPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdPicker.Location = new System.Drawing.Point(172, 149);
            this.bdPicker.Name = "bdPicker";
            this.bdPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bdPicker.Size = new System.Drawing.Size(166, 26);
            this.bdPicker.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(134, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Add request";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Request";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(172, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 26);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(172, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 26);
            this.textBox5.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(172, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "69";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(172, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "@gmail.com";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(172, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(263, 244);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 25);
            this.insert.TabIndex = 0;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.RosyBrown;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(908, 469);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 30);
            this.back.TabIndex = 23;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.time.TabIndex = 34;
            this.time.Text = "TIME";
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
            this.date.TabIndex = 33;
            this.date.Text = "DATE";
            // 
            // setTime
            // 
            this.setTime.Enabled = true;
            this.setTime.Tick += new System.EventHandler(this.setTime_Tick_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add request";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer setTime;
        private System.Windows.Forms.DateTimePicker bdPicker;
    }
}