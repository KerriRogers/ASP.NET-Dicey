using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DICEEv3
{
    public partial class AddURL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SqlConnection conn;
                SqlCommand comm;
                string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
                conn = new SqlConnection(connectionString);
                comm = new SqlCommand("INSERT INTO URL (URL, Rating, Title, DateViewed, Channel, Defendent, Victim, Comments) " +
                "VALUES (@URL, @Rating, @Title, @DateViewed, @Channel, @Defendent, @Victim, @Comments) ", conn);
                
                comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
                comm.Parameters["@URL"].Value = urlTextBox.Text;

                comm.Parameters.Add("@Rating", System.Data.SqlDbType.NChar, 10);
                comm.Parameters["@Rating"].Value = ratingTextBox.Text;

                comm.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Title"].Value = titleTextBox.Text;

                comm.Parameters.Add("@DateViewed", System.Data.SqlDbType.DateTime);
                comm.Parameters["@DateViewed"].Value = dateTextBox.Text;

                comm.Parameters.Add("@Channel", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Channel"].Value = channelTextBox.Text;

                comm.Parameters.Add("@Defendent", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Defendent"].Value = defendentTextBox.Text;

                comm.Parameters.Add("@Victim", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Victim"].Value = victimTextBox.Text;

                comm.Parameters.Add("@Comments", System.Data.SqlDbType.NVarChar, 250);
                comm.Parameters["@Comments"].Value = commentsTextBox.Text;
                
                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                    Response.Redirect("AddURL.aspx");
                    
                }
                catch
                {
                    addErrorMesssage.Text = "Error, try again.";
                }
                finally
                {
                    conn.Close();
                }
            
            }
        }
    }
}