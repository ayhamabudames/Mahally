using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class clsProducts
    {
        public static async Task<List<Product_DTO>> GetAllProducts()
        {
            return await DAL.dalProduct.GetAllProducts();
        }

        public static async Task<List<Product_DTO>> GetLowStockProducts()
        {
            return await dalProduct.GetLowStockProducts();
        }

        public static async Task<List<Product_DTO>> GetOutOfStockProducts()
        {
            return await dalProduct.GetOutOfStockProducts();
        }

        public static async Task<List<Product_DTO>> GetInStockProducts()
        {
            return await dalProduct.GetInStockProducts();
        }

        public static async Task<List<Product_DTO>> GetAllProductsPagination(int pageNumber, int rowsNumber)
        {
            return await DAL.dalProduct.GetAllProductsPagination(pageNumber, rowsNumber);
        }

        public static async Task<List<Product_DTO>> SearchProductsPagination(int pageNumber, int rowsNumber, string searchText)
        {
            return await DAL.dalProduct.SearchProductsPagination(pageNumber, rowsNumber, searchText);
        }

        public static async Task<int> GetProductsCount()
        {
            return await DAL.dalProduct.GetProductsCount();
        }

        public static async Task<int> GetTotalProductsInStock()
        {
            return await dalProduct.GetTotalProductsInStock();
        }

        public static async Task<int> GetTotalProductsLowStock()
        {
            return await dalProduct.GetTotalProductsLowStock();
        }

        public static async Task<Product_DTO> GetProductByID(int productID)
        {
            return await DAL.dalProduct.GetProductByID(productID);
        }

        public static async Task<Product_DTO> GetProductByBarcode(string barcode)
        {
            return await dalProduct.GetProductByBarcode(barcode);
        }

        public static async Task<bool> DeleteProductByID(int productID)
        {
            return await dalProduct.DeleteProductByID(productID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns>returns -1 if the operation failed!!!</returns>
        public static async Task<int> AddNewProduct(Product_DTO newProduct)
        {
            return await dalProduct.AddNewProduct(newProduct);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns>returns true if the operation succeeded, false if failed.</returns>
        public static async Task<bool> UpdateProduct(Product_DTO product)
        {
            return await dalProduct.UpdateProduct(product);
        }

        public static async Task<bool> IsProductExistByBarocode(string barcode)
        {
            return await dalProduct.IsProductExistByBarocode(barcode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns>Tuple income , profite </returns>
        public static async Task<Tuple<decimal, decimal>> GetTotalIncomeAndProfiteInRange(DateTime dateFrom, DateTime dateTo)
        {
            return await dalProduct.GetTotalIncomeAndProfiteInRange(dateFrom, dateTo);
        }

        public static async Task<int> GetTotalSalesInRangeAsync(DateTime From, DateTime To)
        {
            return await dalProduct.GetTotalSalesInRangeAsync(From, To);
        }

        public static async Task<DataTable> GetTopSoldProductsAsync()
        {
            return await dalProduct.GetTopSoldProductsAsync();
        }
    }
}
