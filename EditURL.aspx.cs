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
    public partial class EditURL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void findShowButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT URL, Rating, Title, Defendent, Victim, Comments FROM URL WHERE URL = @URL", conn);
            comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
            comm.Parameters["@URL"].Value = urlEditTextBox.Text;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                URLRepeater.DataSource = reader;
                URLRepeater.DataBind();
                reader.Close();
            }
            catch
            {
                editErrorMessage.Text = "Error, try again.";
            }
            finally
            {
                conn.Close();
                confirmButton.Enabled = true;
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditURL.aspx");
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            // loads the data into the fields to be updated
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT  URL, Title, Rating, Defendent, Victim, Comments FROM URL " +
                "WHERE URL = @URL", conn);

            comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
            comm.Parameters["@URL"].Value = urlEditTextBox.Text;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    titleTextBox.Text = reader["Title"].ToString();
                    ratingTextBox.Text = reader["Rating"].ToString();
                    defendentTextBox.Text = reader["Defendent"].ToString();
                    victimTextBox.Text = reader["Victim"].ToString();
                    commentsTextBox.Text = reader["Comments"].ToString();
                }
                reader.Close();
                updateButton.Enabled = true;

            }
            catch
            {
                editErrorMessage.Text = "Error loading show details! <br />";
            }
            finally
            {
                conn.Close();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
                SqlConnection conn;
                SqlCommand comm;
                string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
                conn = new SqlConnection(connectionString);
                comm = new SqlCommand("UPDATE URL SET Rating = @Rating, Title= @Title, Defendent =@Defendent, Victim= @Victim, Comments=@Comments " +
                "WHERE URL= @URL", conn);
                comm.Parameters.Add("@Rating", System.Data.SqlDbType.NChar, 10);
                comm.Parameters["@Rating"].Value = ratingTextBox.Text;
                comm.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Title"].Value = titleTextBox.Text;
                comm.Parameters.Add("@Defendent", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Defendent"].Value = defendentTextBox.Text;
                comm.Parameters.Add("@Victim", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@Victim"].Value = victimTextBox.Text;
                comm.Parameters.Add("@Comments", System.Data.SqlDbType.NVarChar, 250);
                comm.Parameters["@Comments"].Value = commentsTextBox.Text;
                comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
                comm.Parameters["@URL"].Value = urlEditTextBox.Text;

                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    editErrorMessage.Text = "Error, updating failed";
                }
                finally
                {
                    conn.Close();
                 }
                LoadUpdatedList();
        }

      private void LoadUpdatedList()
      {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT URL, Rating, Title, Defendent, Victim, Comments FROM URL WHERE URL = @URL", conn);
            comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
            comm.Parameters["@URL"].Value = urlEditTextBox.Text;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                URLRepeater.DataSource = reader;
                URLRepeater.DataBind();
                reader.Close();
            }
            catch
            {
                editErrorMessage.Text = "Error, try again.";
            }
            finally
            {
                conn.Close();
                confirmButton.Enabled = true;
                titleTextBox.Text = "";
                ratingTextBox.Text = "";
                defendentTextBox.Text = "";
                victimTextBox.Text = "";
                commentsTextBox.Text = "";
            }
        }

      protected void deleteButton_Click(object sender, EventArgs e)
      {
          SqlConnection conn;
          SqlCommand comm;
         string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
          conn = new SqlConnection(connectionString);
          comm = new SqlCommand("DELETE FROM URL WHERE URL = @URL", conn);
          comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
          comm.Parameters["@URL"].Value = urlEditTextBox.Text;

          conn.Open();
          comm.ExecuteNonQuery();
          conn.Close();

          titleTextBox.Text = "";
          ratingTextBox.Text = "";
          defendentTextBox.Text = "";
          victimTextBox.Text = "";
          commentsTextBox.Text = "";
      }
        
      }
}