using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Otpusk
{
    public partial class _2Vhod : Form
    {
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\practika\\Otpusk\\Data_Otpusk.mdf;Integrated Security=True;Connect Timeout=30";

        public _2Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1Menu f1 = new _1Menu();
            f1.Show();
        }

        private void buttonVhod2_Click(object sender, EventArgs e)
        {
            if (textBoxLogin2.Text == "admin" && textBoxPassword2.Text == "12345")
            {
                this.Hide();
                _4Admin f1 = new _4Admin();
                f1.Show();
            }
            else
            {
                string usr = textBoxLogin2.Text;
                string psw = textBoxPassword2.Text;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

   
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string str = "SELECT * FROM Login where name='" + usr + "' AND password='" + psw + "'";
                    SqlCommand cmd = new SqlCommand(str, con);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0}", reader["Id"])); 
                            MessageBox.Show("Добро пожаловать " + usr);
                            int idUserForm = Int32.Parse(String.Format("{0}", reader["Id"]));
                            this.Hide();
                            _3User f1 = new _3User(idUserForm);
                            f1.Show();
                        }else
                            {
                                MessageBox.Show("Неправильный логин или пароль");
                            }
                    }
                }
                con.Close();
            }
            textBoxLogin2.Text = " ";
            textBoxPassword2.Text = " ";
        }

        private void buttonRegisrt2_Click(object sender, EventArgs e)
        {
            int idUserForms = 1;

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Login(name, password)" +
                  " values('" + textBoxLoginReg2.Text.ToString() + "','" + textBoxPasswordReg2.Text.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();

                string str = "SELECT * FROM Login where name='" + textBoxLoginReg2.Text + "' AND password='" + textBoxPasswordReg2.Text + "'";
                SqlCommand cmds = new SqlCommand(str, con);

                using (SqlDataReader reader = cmds.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", reader["Id"]));
                        idUserForms= Int32.Parse(String.Format("{0}", reader["Id"]));
                    }
                }

                        string qw = "insert into Inform(dolgnost, telephone, fio, id_user)" + 
                    " values('" + textBoxDolgnost_2.Text.ToString() + "','" + textBoxPhone_2.Text.ToString()
                    + "','" + textBoxFIO_2.Text.ToString() + "','" + idUserForms + "') ";
                SqlCommand cmdw = new SqlCommand(qw, con);
                cmdw.ExecuteNonQuery();
            }
            con.Close();

            textBoxDolgnost_2.Text = "";
            textBoxFIO_2.Text = "";
            textBoxPhone_2.Text = " ";
            textBoxLoginReg2.Text = "";
            textBoxPasswordReg2.Text = "";

            MessageBox.Show("Успешно");
        }
    }
}

