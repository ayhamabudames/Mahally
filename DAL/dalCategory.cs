using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalCategory
    {
        public static async Task<List<Category_DTO>> GetAllCategories()
        {
            List<Category_DTO> categories = new List<Category_DTO>();

            string query = @"SELECT * FROM Categories";
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                await con.OpenAsync();
                var reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    int colCategoryID = reader.GetOrdinal("CategoryID");
                    int colTitle = reader.GetOrdinal("Title");

                    while (await reader.ReadAsync())
                    {
                        categories.Add(
                            new Category_DTO(
                                reader.GetInt32(colCategoryID),
                                reader.GetString(colTitle))
                            );
                    }
                }
                else
                {
                    categories = null;
                }
            }
            return categories;
        }
    }
}
