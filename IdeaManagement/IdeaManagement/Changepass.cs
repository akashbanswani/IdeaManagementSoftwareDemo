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
    public partial class Changepass : Form
    {
        public Changepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        public void DoWork()
        {
            // Build Query Use @Name Parameters instead of direct values to prevent SQL Injection
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE signup");
            sql.Append("SET Name = @UpdatedPassword");
            sql.Append("WHERE Password = @Password");

            // Create parameters with the value you want to pass to SQL
           // SqlParameter name = new SqlParameter("@Name", "whatEverOldNameWas");
            SqlParameter updatedPassword = new SqlParameter("@UpdatedPassword", textBox2.Text);

            //Update(sql.ToString(), new[] { Password,updatedPassword });
            //Update(sql.ToString(), [new { updatedPassword });
        }
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = @"Data Source=AKASH-BANSWANI;Initial Catalog=ZoneStartups;Integrated Security=true";
        //    con.Open();
        //    String Password = textBox2.Text;
        //    SqlCommand cmd = new SqlCommand("select password from signup UPDATE Password='" + textBox2.Text +  "'", con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //   // da.Fill(dt);
        //     if (dt.Rows.Count > 0)
        //    {
                

        //    MessageBox.Show("done");

        //}
        //     else

        //     {
        //      MessageBox.Show("Invalid");
        //     }
        //public void DoWork()
        //{
        //    // Build Query Use @Name Parameters instead of direct values to prevent SQL Injection
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("UPDATE UserLogin");
        //    sql.Append("SET Password = @UpdatedPassword");
        //    sql.Append("WHERE Password = @Password");
        //    SqlParameter Password = new SqlParameter("@Password", textBox1.Text);
        //    SqlParameter updatedName = new SqlParameter("@UpdatedName", textBox2.Text);
        //    Update(sql.ToString(), new[] { password, updatedPassword });
        //}
    }
}
    

