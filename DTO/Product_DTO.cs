using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product_DTO
    {
        // ProductID, CategoryID, Barcode, Name, SellPrice, CostPrice, ImageUrl, InStock, MinStockLevel, IsActive, UpdatedAt

        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal SellPrice { get; set; }
        public decimal CostPrice { get; set; }
        public string ImageUrl { get; set; }
        public int InStock { get; set; }
        public int MinStockLevel { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Product_DTO(int productID, int categoryID, string barcode, string name, decimal sellPrice, decimal costPrice, string imageUrl, int inStock, int minStockLevel, bool isActive, DateTime updatedAt)
        {
            ProductID = productID;
            CategoryID = categoryID;
            Barcode = barcode;
            Name = name;
            SellPrice = sellPrice;
            CostPrice = costPrice;
            ImageUrl = imageUrl;
            InStock = inStock;
            MinStockLevel = minStockLevel;
            IsActive = isActive;
            UpdatedAt = updatedAt;
        }

        public Product_DTO( int categoryID, string barcode, string name, decimal sellPrice, decimal costPrice, string imageUrl, int inStock, int minStockLevel, bool isActive)
        {
            CategoryID = categoryID;
            Barcode = barcode;
            Name = name;
            SellPrice = sellPrice;
            CostPrice = costPrice;
            ImageUrl = imageUrl;
            InStock = inStock;
            MinStockLevel = minStockLevel;
            IsActive = isActive;
        }

        public Product_DTO() { }
    }
}
