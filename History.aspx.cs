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
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = ConfigurationManager.ConnectionStrings["URLconnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT URL, Rating, Title, DateViewed, Channel, Defendent, Victim, Comments FROM URL ORDER BY DateViewed DESC", conn);
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                URLRepeater.DataSource = reader;
                URLRepeater.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }

        }
    }
}