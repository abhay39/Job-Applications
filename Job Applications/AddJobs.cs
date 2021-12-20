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
    public partial class AddJobs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C#\gui\Job Applications\Job Applications\JobApplication.mdf;Integrated Security=True;Connect Timeout=30");

        public AddJobs()
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
                    SqlCommand cmd = new SqlCommand("insert into AddJobsTbl(JobTitle, JobAddress,Company,CEO,Experience,Qualification,MonthlySalary,AnnualSalary,EmployeRequired,Others,EndDate) values(@JT,@JA,@C,@CEO,@E,@Q,@MS,@AS,@ER,@O,@ED)", con);
                    cmd.Parameters.AddWithValue("@JT", jobtitletb.Text);
                    cmd.Parameters.AddWithValue("@JA", jobaddressrtb.Text);
                    cmd.Parameters.AddWithValue("@C", cnametb.Text);
                    cmd.Parameters.AddWithValue("@CEO", ceotb.Text);
                    cmd.Parameters.AddWithValue("@E", experiecntb.Text);
                    cmd.Parameters.AddWithValue("@Q", qualificationtb.Text);
                    cmd.Parameters.AddWithValue("@MS", mnthlytb.Text);
                    cmd.Parameters.AddWithValue("@AS", annualsalary.Text);
                    cmd.Parameters.AddWithValue("@ER", ereq.Text);
                    cmd.Parameters.AddWithValue("@O", other.Text);
                    cmd.Parameters.AddWithValue("@ED", datepicker.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Job Successfully Added.");
                    Reset();
                    con.Close();
                }catch (Exception exe)
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
            mnthlytb.Text = "";
            annualsalary.Text = "";
            ereq.Text = ""; 
            other.Text = "";
        }
        private void clearbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
