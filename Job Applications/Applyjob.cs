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
    public partial class Applyjob : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C#\gui\Job Applications\Job Applications\JobApplication.mdf;Integrated Security=True;Connect Timeout=30");

        public Applyjob()
        {
            InitializeComponent();
        }

        private void addjobbtn_Click(object sender, EventArgs e)
        {
            if (jobtitletb.Text == "" || jobaddressrtb.Text == "")
            {
                MessageBox.Show("Missing Informations..");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ApplyJobTbl(JobTitle, JobAddress,Company,CEO,Experience,Qualification,WorkExperience,Skills) values(@JT,@JA,@C,@CEO,@E,@Q,@WE,@S)", con);
                    cmd.Parameters.AddWithValue("@JT", jobtitletb.Text);
                    cmd.Parameters.AddWithValue("@JA", jobaddressrtb.Text);
                    cmd.Parameters.AddWithValue("@C", cnametb.Text);
                    cmd.Parameters.AddWithValue("@CEO", ceotb.Text);
                    cmd.Parameters.AddWithValue("@E", experiecntb.Text);
                    cmd.Parameters.AddWithValue("@Q", qualificationtb.Text);
                    cmd.Parameters.AddWithValue("@WE", workexp.Text);
                    cmd.Parameters.AddWithValue("@S", skillstb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Job Applied Successfully.");
                    Reset();
                    con.Close();
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }

            }
        }
        public void Reset()
        {
            jobtitletb.Text = "";
            jobaddressrtb.Text = "";
            cnametb.Text = "";
            ceotb.Text = "";
            experiecntb.Text = "";
            qualificationtb.Text = "";
            workexp.Text = "";
            skillstb.Text = "";
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
