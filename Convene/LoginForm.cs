
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;



namespace Convene
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
           
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ConveneDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@user AND Password=@pass";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", txtLoginUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtLoginPassword.Text);

                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            this.Hide();
                            Convene_Form mainApp = new Convene_Form(); //opn the homepage
                            mainApp.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_createacc_Click(object sender, EventArgs e)
        {

            pnl_createaccselect.BackColor = Color.FromArgb(248, 248, 255);
            pnl_createaccselect.BorderColor = Color.FromArgb(224, 224, 224);
            lb_createacc.ForeColor = Color.FromArgb(79, 70, 229);

            pnl_signinselect.BackColor = Color.Transparent;
            pnl_signinselect.BorderColor = Color.Transparent;
            lb_signin.ForeColor = Color.Gray;

            pnl_createaccountsection.Visible = true;
            pnl_signinsection.Visible = false;
            pnl_signinsection.BringToFront();


        }

        private void pnl_signinselect_Click(object sender, EventArgs e)
        {
            pnl_signinselect.BackColor = Color.FromArgb(248, 248, 255);
            pnl_signinselect.BorderColor = Color.FromArgb(224, 224, 224);
            lb_signin.ForeColor = Color.FromArgb(79, 70, 229);

            pnl_createaccselect.BackColor = Color.Transparent;
            pnl_createaccselect.BorderColor = Color.Transparent;
            lb_createacc.ForeColor = Color.Gray;

            pnl_createaccountsection.Visible = false;
            pnl_signinsection.Visible = true;
            pnl_signinsection.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pnl_createaccselect_Paint(object sender, PaintEventArgs e)
        {
            bool enabled = false;
            enabled = !enabled;




        }

        private void pnl_signinselect_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            
            if (txtRegPassword.Text != txtRegConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ConveneDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", txtRegUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtRegPassword.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created! Please sign in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //if register is good, go back to sing in
                        pnl_signinselect_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }//btnREgister end
    


    }
}
