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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT URL, Rating, Title, DateViewed, Comments FROM URL WHERE URL = @URL ORDER BY DateViewed DESC", conn);
            comm.Parameters.Add("@URL", System.Data.SqlDbType.NVarChar, 250);
            comm.Parameters["@URL"].Value = urlEntryTextBox.Text;
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
                dbErrorMessage.Text = "Error, try again.";
            }
            finally
            {
                conn.Close();
            }

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}