using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SarsoShoppingMVC.Models
{
    public class ShopRepository
    {
        public DataTable Call_Getrpcategories(string Action, string Category, string Category1)
        {
            DataTable dt = new DataTable();
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Getrpcategories_SP"))
                    {
                        cmd.Parameters.Add("@action", SqlDbType.VarChar).Value = Action;
                        cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = Category;
                        cmd.Parameters.Add("@category1", SqlDbType.VarChar).Value = Category1;

                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return dt;
        }
    }
}