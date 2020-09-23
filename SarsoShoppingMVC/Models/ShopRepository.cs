using SarsoShoppingData;
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

        public DataTable TempCart(string action, string UNQId, string Pcode, string ItemCode, string Attribute, string Qty)
        {
            DataTable dt = new DataTable();
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("TempCart_SP"))
                    {
                        cmd.Parameters.Add("@action", SqlDbType.VarChar).Value = action;
                        cmd.Parameters.Add("@UNQId", SqlDbType.VarChar).Value = UNQId;
                        cmd.Parameters.Add("@Pcode", SqlDbType.VarChar).Value = Pcode;
                        cmd.Parameters.Add("@ItemCode", SqlDbType.VarChar).Value = ItemCode;
                        cmd.Parameters.Add("@Attribute", SqlDbType.VarChar).Value = Attribute;
                        cmd.Parameters.Add("@Qty", SqlDbType.VarChar).Value = Qty;

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

        public DataTable GetMemberDetail(string regId)
        {

            DataTable dt = new DataTable();
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("MemberDetailes_Sp"))
                    {
                        cmd.Parameters.Add("@regid", SqlDbType.VarChar).Value = regId;
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

        public List<GetStates_Sp_Result> GetStates()
        {
            List<GetStates_Sp_Result> StateList = new List<GetStates_Sp_Result>();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    StateList = entities.GetStates_Sp(1).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return StateList;
        }
        public string GetCourier()
        {
            string jsoNresult = string.Empty;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    var CourierLsit = entities.CourierMaster_SP("Courier").ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return jsoNresult;
        }

        public Int32 TempOrder(string UNQId, string regid, string downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode)
        {
            Int32 result;
            using (var entities = new sarsobizEntities())
            {
                result = entities.TempOrder_SP(UNQId, Convert.ToInt32(regid), Convert.ToInt32(downlineid), mop, Convert.ToDecimal(mopamt), Fname, LName, Mobile, Address, City, District, state, PiCode).FirstOrDefault() ?? 0;
            }
            return result;
        }
    }
}