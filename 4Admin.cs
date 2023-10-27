using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otpusk
{
    public partial class _4Admin : Form
    {
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\practika\\Otpusk\\Data_Otpusk.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\practika\\Otpusk\\Data_Otpusk.mdf;Integrated Security=True;Connect Timeout=30");
        public _4Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2Vhod f1 = new _2Vhod();
            f1.Show();
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string str = "SELECT * FROM DniOtpuska where id_user='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", reader["date_start"]));
                        string dataStart = String.Format("{0}", reader["date_start"]).Substring(0, 10);
                        Console.WriteLine(String.Format("{0}", reader["date_end"]));
                        string dataEnd = String.Format("{0}", reader["date_end"]).Substring(0, 10);
                        string forBox = "s " + dataStart + " po " + dataEnd;
                        comboBox1.Items.Add(forBox);
 
                    }
                }
            }
            con.Close();
        }

        private void _4Admin_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Inform", con);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            con.Close();
        }
    }
}
