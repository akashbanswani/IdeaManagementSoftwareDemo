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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=AKASH-BANSWANI;Initial Catalog=ZoneStartups;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Post (Title,Discribtion,Likecount,Dislikecount,Datetime)VALUES(@Title, @Discribtion, @Likecount, @Dislikecount, @Datetime)", con))
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                    cmd.Parameters.AddWithValue("@Discribtion", txtdescribtion.Text);
                    cmd.Parameters.AddWithValue("@Likecount", 0);
                    cmd.Parameters.AddWithValue("@Dislikecount", 0);
                    cmd.Parameters.AddWithValue("@Datetime", dateTime1.Value);
                    con.Open();
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("successfull");
                    con.Close();

                }
            }

            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("Title");
            dt.Columns.Add("Discribtion");
            dt.Columns.Add("Likecount");
            dt.Columns.Add("Dislikecount");
            dt.Columns.Add("Datetime");
            dr = dt.NewRow();
            dr["Title"] = txttitle.Text;
            dr["Discribtion"] = txtdescribtion.Text;
            dr["Likecount"] = 0;
            dr["Dislikecount"] = 0;
            dr["Datetime"] = dateTime1.Value;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;  




        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zoneStartupsDataSet.signup' table. You can move, or remove it, as needed.
            this.signupTableAdapter.Fill(this.zoneStartupsDataSet.signup);
            // TODO: This line of code loads data into the 'zoneStartupsDataSet.Post' table. You can move, or remove it, as needed.
           // this.postTableAdapter.Fill(this.zoneStartupsDataSet.Post);

        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                Changepass ch = new Changepass();
                ch.Show();
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        }
    
    }


