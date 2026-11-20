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
    public class dalProduct
    {
        public static async Task<List<Product_DTO>> GetAllProductsPagination(int pageNumber, int rowsNumber)
        {
            var products = new List<Product_DTO>();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetProductsPagination", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                cmd.Parameters.AddWithValue("@RowsNumber", rowsNumber);

                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<List<Product_DTO>> GetAllProducts()
        {
            var products = new List<Product_DTO>();
            string query = @"SELECT * FROM PRODUCTS WHERE IsActive = 1;";
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<List<Product_DTO>> GetLowStockProducts()
        {
            var products = new List<Product_DTO>();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_LowStockProducts", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<List<Product_DTO>> GetOutOfStockProducts()
        {
            var products = new List<Product_DTO>();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_OutOfStockProducts", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<List<Product_DTO>> GetInStockProducts()
        {
            var products = new List<Product_DTO>();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_InStockProducts", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<List<Product_DTO>> SearchProductsPagination(int pageNumber, int rowsNumber, string searchText)
        {
            var products = new List<Product_DTO>();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_SearchProductsPagination", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
                cmd.Parameters.AddWithValue("@RowsNumber", rowsNumber);
                cmd.Parameters.AddWithValue("@SearchText", searchText);

                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");

                        while (await reader.ReadAsync())
                        {
                            products.Add(new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            ));
                        }
                    }
                }
                return products;
            }

        }

        public static async Task<int> GetProductsCount()
        {
            int totalCount = 0;
            string query = "SELECT COUNT(1) FROM Products WHERE IsActive = 1;";

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.Text;

                await con.OpenAsync();

                object result = await cmd.ExecuteScalarAsync();

                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    totalCount = count;
                }
            }

            return totalCount;
        }

        public static async Task<Product_DTO> GetProductByID(int productId)
        {
            Product_DTO product = null;
            string query = "SELECT * FROM Products WHERE ProductID = @ProductID AND IsActive = 1;";
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);
                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");
                        if (await reader.ReadAsync())
                        {
                            product = new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            );
                        }
                    }
                    return product;
                }
            }

        }

        public static async Task<Product_DTO> GetProductByBarcode(string barcode)
        {
            Product_DTO product = null;
            string query = "SELECT * FROM Products WHERE Barcode = @Barcode AND IsActive = 1;";
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        int colProductID = reader.GetOrdinal("ProductID");
                        int colCategoryID = reader.GetOrdinal("CategoryID");
                        int colBarcode = reader.GetOrdinal("Barcode");
                        int colName = reader.GetOrdinal("Name");
                        int colSellPrice = reader.GetOrdinal("SellPrice");
                        int colCostPrice = reader.GetOrdinal("CostPrice");
                        int colImageUrl = reader.GetOrdinal("ImageUrl");
                        int colInStock = reader.GetOrdinal("InStock");
                        int colMinStockLevel = reader.GetOrdinal("MinStockLevel");
                        int colIsActive = reader.GetOrdinal("IsActive");
                        int colUpdatedAt = reader.GetOrdinal("UpdatedAt");
                        if (await reader.ReadAsync())
                        {
                            product = new Product_DTO(
                                productID: reader.GetInt32(colProductID),
                                categoryID: reader.GetInt32(colCategoryID),
                                barcode: reader.GetString(colBarcode),
                                name: reader.GetString(colName),
                                sellPrice: reader.GetDecimal(colSellPrice),
                                costPrice: reader.GetDecimal(colCostPrice),
                                imageUrl: reader.IsDBNull(colImageUrl) ? string.Empty : reader.GetString(colImageUrl),
                                inStock: reader.GetInt32(colInStock),
                                minStockLevel: (short)reader.GetInt32(colMinStockLevel),
                                isActive: reader.GetBoolean(colIsActive),
                                updatedAt: reader.GetDateTime(colUpdatedAt)
                            );
                        }
                    }
                    return product;
                }
            }

        }

        public static async Task<int> GetTotalProductsInStock()
        {
            int totalCount = 0;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_TotalProductsInStock", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                await con.OpenAsync();

                object result = await cmd.ExecuteScalarAsync();

                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    totalCount = count;
                }
            }

            return totalCount;
        }

        public static async Task<int> GetTotalProductsLowStock()
        {
            int totalCount = 0;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_TotalProductsLowStock", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                await con.OpenAsync();

                object result = await cmd.ExecuteScalarAsync();

                if (result != null && int.TryParse(result.ToString(), out int count))
                {
                    totalCount = count;
                }
            }

            return totalCount;
        }

        public static async Task<bool> DeleteProductByID(int productID)
        {
            bool result = false;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_DeleteProduct", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", productID);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();

                result = await cmd.ExecuteNonQueryAsync() != 1;
                if ((int)pReturn.Value == 1)
                {
                    result = true;
                }

            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns>returns -1 if the operation failed!!!</returns>
        public static async Task<int> AddNewProduct(Product_DTO newProduct)
        {
            int newProductID = -1;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_AddProduct", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryID", newProduct.CategoryID);
                cmd.Parameters.AddWithValue("@Barcode", newProduct.Barcode);
                cmd.Parameters.AddWithValue("@Name", newProduct.Name);
                cmd.Parameters.AddWithValue("@SellPrice", newProduct.SellPrice);
                cmd.Parameters.AddWithValue("@CostPrice", newProduct.CostPrice);
                cmd.Parameters.AddWithValue("@ImageUrl", (object)newProduct.ImageUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InStock", newProduct.InStock);
                cmd.Parameters.AddWithValue("@MinStockLevel", newProduct.MinStockLevel);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                SqlParameter pNewID = cmd.Parameters.Add("@NewID", SqlDbType.Int);
                pNewID.Direction = ParameterDirection.Output;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                if ((int)pReturn.Value == 1)
                {
                    newProductID = (int)pNewID.Value;
                }
            }
            return newProductID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns>returns true if the operation succeeded, false if failed.</returns>
        public static async Task<bool> UpdateProduct(Product_DTO product)
        {
            bool isUpdated = false;

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_UpdateProduct", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                cmd.Parameters.AddWithValue("@Barcode", product.Barcode);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@SellPrice", product.SellPrice);
                cmd.Parameters.AddWithValue("@CostPrice", product.CostPrice);
                cmd.Parameters.AddWithValue("@ImageUrl", (object)product.ImageUrl ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@InStock", product.InStock);
                cmd.Parameters.AddWithValue("@MinStockLevel", product.MinStockLevel);

                SqlParameter pReturn = cmd.Parameters.Add("@Return", SqlDbType.Int);
                pReturn.Direction = ParameterDirection.ReturnValue;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                isUpdated = ((int)pReturn.Value == 1);
            }

            return isUpdated;
        }

        public static async Task<bool> IsProductExistByBarocode(string barcode)
        {
            bool isFound = false;
            string query = @"SELECT Found = 1 FROM Products
                            WHERE Barcode = @Barcode";
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                await con.OpenAsync();

                isFound = await cmd.ExecuteScalarAsync() != null;
            }
            return isFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="From"></param>
        /// <param name="To"></param>
        /// <returns>Tupe <income , profite> </returns>
        public static async Task<Tuple<decimal, decimal>> GetTotalIncomeAndProfiteInRange(DateTime From, DateTime To)
        {
            Tuple<decimal, decimal> incomeAndProfite = null;

            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetTotalIncomeAndProfiteInRange", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@To", To);

                SqlParameter pIncome = cmd.Parameters.Add("@Income", SqlDbType.Decimal);
                pIncome.Precision = 10;
                pIncome.Scale = 2;
                pIncome.Direction = ParameterDirection.Output;

                SqlParameter pProfite = cmd.Parameters.Add("@Profite", SqlDbType.Decimal);
                pProfite.Precision = 10;
                pProfite.Scale = 2;
                pProfite.Direction = ParameterDirection.Output;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

                decimal income = (pIncome.Value != DBNull.Value) ? Convert.ToDecimal(pIncome.Value) : 0m;
                decimal profite = (pProfite.Value != DBNull.Value) ? Convert.ToDecimal(pProfite.Value) : 0m;

                incomeAndProfite = Tuple.Create(income, profite);
            }

            return incomeAndProfite;
        }

        public static async Task<int> GetTotalSalesInRangeAsync(DateTime From, DateTime To)
        {
            int sales = 0;
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_GetTotalSalesInRange", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@To", To);

                SqlParameter pResult = cmd.Parameters.Add("@Result", SqlDbType.Int);
                pResult.Direction = ParameterDirection.Output;

                await con.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                sales = (int)pResult.Value;
            }
            return sales;
        }

        public static async Task<DataTable> GetTopSoldProductsAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(dalSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("USP_TopSoldProducts", con))
            {
                await con.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }

        }
    }
}
