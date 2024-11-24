using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        String connectionString = "Data source=csharp2022_2.db;Version=3";
        SQLiteConnection connection;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //create Db KEP if not exist
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            String createSQL = "Create table if not exists KEP(Req_ID integer primary key autoincrement," +
                "nameSurname Text,email Text,phone integer,bd Text,request Text,address Text,dayTimeRequest Text)";
            SQLiteCommand command = new SQLiteCommand(createSQL, connection);
            command.ExecuteNonQuery();
            connection.Close();

            setTime.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            //check if textbox is not empty 
            if (textBox1.Text != "" && textBox2.Text != "" && PhoneCheck.IsPhoneNbr(textBox3.Text) && textBox5.Text != "" && textBox6.Text != "")
            {
                //insert data to KEP
                DateTime dt = DateTime.Now;
                connection.Open();
                String insertSQL = "Insert into KEP(nameSurname,email,phone,bd,request,address,dayTimeRequest) values(@name,@email,@phone,@bd,@request,@address,@dtrequest)";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("name", textBox1.Text);
                command.Parameters.AddWithValue("email", textBox2.Text);
                command.Parameters.AddWithValue("phone", Convert.ToInt64(textBox3.Text));
                command.Parameters.AddWithValue("bd", bdPicker.Text);
                command.Parameters.AddWithValue("request", textBox5.Text);
                command.Parameters.AddWithValue("address", textBox6.Text);
                command.Parameters.AddWithValue("dtrequest", dt.ToString("dddd dd/MM/yyyy HH:mm"));
                command.ExecuteNonQuery();
                connection.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                MessageBox.Show("Successfull request!");
            }
            else
            {
                MessageBox.Show("Invalid Info");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Close();
        }

        private void setTime_Tick_1(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            setTime.Start();
        }
    }
}
