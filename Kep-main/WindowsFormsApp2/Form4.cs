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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        Login login = new Login("admin", "admin");

        private void insert_Click(object sender, EventArgs e)
        {
            //check if username and password is correct
            if(login.Username == textBox1.Text && login.Password == textBox2.Text)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Info");
            }
        }
    }
}
