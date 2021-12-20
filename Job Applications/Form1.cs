using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Applications
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C#\gui\Income-Expanse-Management-master\IncomeExapanseDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }
        public static string User;
        private void label2_Click(object sender, EventArgs e)
        {
            createanaccount ca = new createanaccount();
            ca.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            usernametb.Text = "";
            passtb.Text = "";
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (usernametb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Missing Information..");
            }
            else
            {
               
                    User = usernametb.Text;
                    HomePage hp = new HomePage();
                    hp.Show();
                    this.Hide();
                    con.Close();
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
