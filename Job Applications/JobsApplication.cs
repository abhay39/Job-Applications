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
    public partial class JobsApplication : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C#\gui\Job Applications\Job Applications\JobApplication.mdf;Integrated Security=True;Connect Timeout=30");

        public JobsApplication()
        {
            InitializeComponent();
            Populate();
        }
        public void Populate()
        {
            con.Open();
            string Query = "select * from ApplyJobTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            jobsgdv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void createbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
