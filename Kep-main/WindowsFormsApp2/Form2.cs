using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            setTime.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
            this.Close();
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void setTime_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            setTime.Start();    
        }
    }
}
