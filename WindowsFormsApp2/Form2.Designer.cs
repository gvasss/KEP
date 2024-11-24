namespace WindowsFormsApp2
{
    partial class Form2
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
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Gray;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.add.Location = new System.Drawing.Point(294, 310);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 74);
            this.add.TabIndex = 1;
            this.add.Text = "Εισαγωγή νέου αιτήματος";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.RosyBrown;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(912, 469);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(60, 30);
            this.exit.TabIndex = 5;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.kep__1_;
            this.pictureBox1.Location = new System.Drawing.Point(294, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Gray;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(480, 310);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(180, 74);
            this.edit.TabIndex = 6;
            this.edit.Text = "Επεξεργασία αιτημάτων";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
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
            this.time.TabIndex = 36;
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
            this.date.TabIndex = 35;
            this.date.Text = "DATE";
            // 
            // setTime
            // 
            this.setTime.Enabled = true;
            this.setTime.Tick += new System.EventHandler(this.setTime_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer setTime;
    }
}