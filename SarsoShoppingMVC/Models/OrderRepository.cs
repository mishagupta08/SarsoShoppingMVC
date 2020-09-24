using SarsoShoppingData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SarsoShoppingMVC.Models
{
    public class OrderRepository
    {
        

        public DataTable CallSCOrder(string uniqID, Nullable<decimal> regid, string ordertype, Nullable<decimal> shpchrg, string sesid, string ipadd, string scmemtype)
        {            
            DataTable dt = new DataTable();
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SCOrderPG_SP"))
                    {
                            cmd.Parameters.Add("@uniqID", SqlDbType.VarChar).Value = uniqID;
                            cmd.Parameters.Add("@regid", SqlDbType.Int).Value = regid;
                            cmd.Parameters.Add("@ordertype", SqlDbType.VarChar).Value = ordertype;
                            cmd.Parameters.Add("@shpchrg", SqlDbType.Float).Value = shpchrg;
                            cmd.Parameters.Add("@sesid", SqlDbType.VarChar).Value = sesid;
                            cmd.Parameters.Add("@ipadd", SqlDbType.VarChar).Value = ipadd;
                            cmd.Parameters.Add("@scmemtype", SqlDbType.VarChar).Value = scmemtype;

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

        public DataTable SCOnlineInsert_Sp(string uniqID, Nullable<decimal> regid, string ordertype, Nullable<decimal> shpchrg, string sesid, string ipadd, string scmemtype)
        {
            DataTable dt = new DataTable();
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SCOrderPG_SP"))
                    {
                        cmd.Parameters.Add("@uniqID", SqlDbType.VarChar).Value = uniqID;
                        cmd.Parameters.Add("@regid", SqlDbType.Int).Value = regid;
                        cmd.Parameters.Add("@ordertype", SqlDbType.VarChar).Value = ordertype;
                        cmd.Parameters.Add("@shpchrg", SqlDbType.Float).Value = shpchrg;
                        cmd.Parameters.Add("@sesid", SqlDbType.VarChar).Value = sesid;
                        cmd.Parameters.Add("@ipadd", SqlDbType.VarChar).Value = ipadd;
                        cmd.Parameters.Add("@scmemtype", SqlDbType.VarChar).Value = scmemtype;

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