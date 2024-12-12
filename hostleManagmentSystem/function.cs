using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hostleManagmentSystem
{
    internal class function
    {
        // Method to establish a database connection
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = BUSHRA-JABBAR; database = hostel; integrated security = true";
            return con;
        }

        // Method to fetch data using a SELECT query
        public DataSet getData(string query)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Method to execute INSERT/UPDATE/DELETE queries
        public void setData(string query, string msg)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to execute parameterized queries
        public void setDataWithParams(string query, SqlParameter[] parameters, string msg)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddRange(parameters);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
