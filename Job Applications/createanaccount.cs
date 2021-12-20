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

namespace Job_Applications
{
    public partial class createanaccount : Form
    {
        public createanaccount()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\C#\gui\Job Applications\Job Applications\JobApplication.mdf;Integrated Security=True;Connect Timeout=30");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        public void Reset()
        {
            firsttb.Text = "";
            lasttb.Text = "";
            fathertb.Text = "";
            mothettb.Text = "";
            addresstb.Text = "";
            contacttb.Text = "";
            gendercb.SelectedIndex = -1;
            marititacb.SelectedIndex = -1;
            educationccb.SelectedIndex = -1;
            emailtb.Text = "";
            usernamtb.Text = "";
            passtb.Text = "";
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (firsttb.Text==""||lasttb.Text == ""||usernamtb.Text == "" ||passtb.Text == "")
            {
                MessageBox.Show("All Fields are Required!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into createaccounttbl(FirstName, LastName, FatherName, MotherName, Address, ContactNumber, Gender, DOB, Maritial, Education, EmailID, Username, Password ) values(@FN,@LN,@FAN,@MN,@A,@CN,@G,@D,@M,@E,@EID,@U,@P)", con);
                    cmd.Parameters.AddWithValue("@FN", firsttb.Text);
                    cmd.Parameters.AddWithValue("@LN", lasttb.Text);
                    cmd.Parameters.AddWithValue("@FAN", fathertb.Text);
                    cmd.Parameters.AddWithValue("@MN", mothettb.Text);
                    cmd.Parameters.AddWithValue("@A", addresstb.Text);
                    cmd.Parameters.AddWithValue("@CN", contacttb.Text);
                    cmd.Parameters.AddWithValue("@G", gendercb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@D", datepicker.Text);
                    cmd.Parameters.AddWithValue("@M", marititacb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@E", educationccb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EID", emailtb.Text);
                    cmd.Parameters.AddWithValue("@U", usernamtb.Text);
                    cmd.Parameters.AddWithValue("@P", passtb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Craeted The Account.");
                    con.Close();
                    Reset();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
