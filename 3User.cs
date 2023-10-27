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
    public partial class _3User : Form
    {
        int id_user = 1;
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\practika\\Otpusk\\Data_Otpusk.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\practika\\Otpusk\\Data_Otpusk.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;


        public _3User(int idUserForm)
        {
            InitializeComponent();
            id_user = idUserForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2Vhod f1 = new _2Vhod ();
            f1.Show();
        }

        private void _3User_Load(object sender, EventArgs e)
        {
            labelName3.Text = " ";
            labelFIO_3.Text = " ";
            labelPhone_3.Text = " ";
            labelDolgnost_3.Text = " ";

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string str = "SELECT * FROM Inform where id_user='" + id_user + "'";
                SqlCommand cmd = new SqlCommand(str, con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", reader["dolgnost"]));
                        string userDolg = String.Format("{0}", reader["dolgnost"]);
                        Console.WriteLine(String.Format("{0}", reader["telephone"]));
                        string userPhone = String.Format("{0}", reader["telephone"]);
                        Console.WriteLine(String.Format("{0}", reader["fio"]));
                        string userFio = String.Format("{0}", reader["fio"]);
                        labelDolgnost_3.Text = userDolg;
                        labelFIO_3.Text = userFio;
                        labelPhone_3.Text = userPhone;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                {
                    string strs = "SELECT * FROM Login where Id='" + id_user + "'";
                    SqlCommand cmds = new SqlCommand(strs, con);

                    using (SqlDataReader reader = cmds.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}", reader["name"]));
                            string user_name = String.Format("{0}", reader["name"]);
                            labelName3.Text = user_name;
                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
                con.Close();
            }
            
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            string dataStart = monthCalendar3.SelectionRange.Start.ToString("yyyy-MM-dd");
            string dataEnd = monthCalendar3.SelectionRange.End.ToString("yyyy-MM-dd");
            
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into DniOtpuska(date_start, date_end, id_user)" +
                  " values('" + dataStart + "', '" + dataEnd + "','" + id_user + "') ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
