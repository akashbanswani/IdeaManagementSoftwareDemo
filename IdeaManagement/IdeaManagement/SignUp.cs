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

namespace IdeaManagement
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            string constring = @"Data Source=AKASH-BANSWANI;Initial Catalog=ZoneStartups;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO signup (Name,Email,Address,Mobile,Password)VALUES(@Name, @Email, @Address, @Mobile, @Password)", con))
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtadd.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtmobile.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign up Successfully");
                    con.Close();
                }
            }
            this.Close();
            Home h = new Home();
            h.Show();
            }
                catch
            {
                MessageBox.Show("This Email has alredy been taken \n please try with different emailID");
                }
                }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == textBox4.Text)
            {

            }
            else
            {
                MessageBox.Show("Password Do Not Match");
            }
        }

       
                
            }
        
        
            
        }
          
    
            
    //        String str = "server=AKASH-BANSWANI;database=ZoneStartups";
       //  String query = "insert into signup (Name,Email,Address,Mobile,Password) values ('" + this.txtname.Text + "','" + this.txtemail.Text +"','" + this.txtadd.Text + "','" + this.txtmobile.Text + "','" + this.txtpassword.Text +"')";
    //        SqlCommand cmd = new SqlCommand(query, con);
    //        SqlDataReader dbr;
    //        try
    //        {
    //            con.Open();
    //            dbr = cmd.ExecuteReader();
    //            MessageBox.Show("saved");
    //            while (dbr.Read())
    //            {
    //            }
    //        }
    //        catch (Exception es)
    //        {
    //            MessageBox.Show(es.Message);
    //        }
    //    }

    //}
        
    