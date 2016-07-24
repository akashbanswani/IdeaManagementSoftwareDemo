using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;  
using System.Data.OleDb;  
using System.Data.SqlClient;
namespace IdeaManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=AKASH-BANSWANI;Initial Catalog=ZoneStartups;Integrated Security=true";
            con.Open();
            String Email = txtuser.Text;
            String Password = txtpass.Text;
            SqlCommand cmd = new SqlCommand("select Email,password from signup where Email='" + txtuser.Text + "'and password='" + txtpass.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               

                MessageBox.Show("LOGED IN SUCCESSFULLY");
                
                Home k = new Home();
                k.Show();


                
                
                

                //String Name = txtuser.Text;
                //SqlCommand cm= new SqlCommand("select Name from signup where Name ='"+ txtuser.Text+"'",con);
                //SqlDataAdapter de = new SqlDataAdapter(cmd);
              
                //de.Fill(dt);
                
                
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();


            Form1 frm = new Form1();
            frm.Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            
        }


    }
}


       


    

