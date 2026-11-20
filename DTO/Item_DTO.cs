using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Item_DTO
    {
        public int ItemID {get;set;}
        public int ProductID{get;set;}
        public int SellID { get;set;}
        public decimal UnitPrice { get;set;}
        public int Quantity { get;set;}

        public Item_DTO() { }
        public Item_DTO(int itemID , int productID , int sellID ,decimal unitPrice,int quantity)
        {
            ItemID    = itemID;
            ProductID = productID;
            SellID    = sellID;
            UnitPrice = unitPrice;
            Quantity  = quantity;
        }
    }
}
