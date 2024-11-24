using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String connectionString = "Data source=csharp2022_2.db;Version=3";
        SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            setTime.Start();
            time.Text=DateTime.Now.ToLongTimeString();
            date.Text=DateTime.Now.ToLongDateString();  
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //delete request by ID
            connection.Open();
            String deleteRequest = "delete from KEP where Req_id=@id";
            SQLiteCommand command = new SQLiteCommand(deleteRequest, connection);
            command.Parameters.AddWithValue("id", textBoxDelID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            textBoxDelID.Clear();

            //refresh richtextbox
            show_Click(sender, e);
        }

        private void searchBName_Click(object sender, EventArgs e)
        {
            //search by name and show in richtextbox
            richTextBox1.Clear();
            connection.Open();
            String selectSQL = "Select * from KEP where nameSurname=@name";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("name", textBoxNameSrh.Text);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                richTextBox1.AppendText("Request ID: ");
                richTextBox1.AppendText(reader.GetInt16(0).ToString());
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Name: ");
                richTextBox1.AppendText(reader.GetString(1));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Email: ");
                richTextBox1.AppendText(reader.GetString(2));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Phone: ");
                richTextBox1.AppendText(reader.GetInt64(3).ToString());
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Birthday: ");
                richTextBox1.AppendText(reader.GetString(4));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Request: ");
                richTextBox1.AppendText(reader.GetString(5));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Address: ");
                richTextBox1.AppendText(reader.GetString(6));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Day/Time req: ");
                richTextBox1.AppendText(reader.GetString(7));

                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(Environment.NewLine);
            }
            connection.Close();
            textBoxNameSrh.Clear();
        }

        private void upd_Click(object sender, EventArgs e)
        {
            //update name by ID
            connection.Open();
            String updRequest = "update KEP set nameSurname=@name where Req_id=@id";
            SQLiteCommand command = new SQLiteCommand(updRequest, connection);
            command.Parameters.AddWithValue("id", textBoxUpd.Text);
            command.Parameters.AddWithValue("name", textBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            textBox1.Clear();
            textBoxUpd.Clear();

            //refresh richtextbox
            show_Click(sender, e);
        }

        private void show_Click(object sender, EventArgs e)
        {
            //show all requests and "refresh" when delete and update done
            richTextBox1.Clear();
            connection.Open();
            String selectSQL = "Select * from KEP";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText("Request ID: ");
                richTextBox1.AppendText(reader.GetInt16(0).ToString());
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Name: ");
                richTextBox1.AppendText(reader.GetString(1));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Email: ");
                richTextBox1.AppendText(reader.GetString(2));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Phone: ");
                richTextBox1.AppendText(reader.GetInt64(3).ToString());
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Birthday: ");
                richTextBox1.AppendText(reader.GetString(4));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Request: ");
                richTextBox1.AppendText(reader.GetString(5));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Address: ");
                richTextBox1.AppendText(reader.GetString(6));
                richTextBox1.AppendText(", ");

                richTextBox1.AppendText("Day/Time req: ");
                richTextBox1.AppendText(reader.GetString(7));

                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText(Environment.NewLine);

            }
            connection.Close();
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
