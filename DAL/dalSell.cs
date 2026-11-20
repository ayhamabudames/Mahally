using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalSell
    {
        public static async Task<bool> InvoiceSell(int userID,List<Item_DTO> items)
        {
            DataTable dtItems = new DataTable();
            dtItems.Columns.Add("ProductID",typeof(int));
            dtItems.Columns.Add("SellID" , typeof(int));
            dtItems.Columns.Add("UnitPrice" , typeof(decimal));
            dtItems.Columns.Add("Quantity" , typeof(int));

            foreach(var i in items)
            {
                dtItems.Rows.Add(i.ProductID, -1, i.UnitPrice, i.Quantity);
            }

            try
            {
                using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("USP_InvoiceSell", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    SqlParameter tvpParam = cmd.Parameters.Add("@ItemsTable", SqlDbType.Structured);
                    tvpParam.Value = dtItems;
                    tvpParam.TypeName = "ItemsTable";

                    await con.OpenAsync();

                    await cmd.ExecuteNonQueryAsync();

                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("67 : " + ex.Message);
                return false;
            }

        } 
    }
}
