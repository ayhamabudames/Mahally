using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sell_DTO
    {
        public int SellID { get; set; }
        public int UserID{ get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Date{ get; set; }

        public Sell_DTO(int sellID, int userID, decimal totalAmount, DateTime date)
        {
            SellID      = sellID;
            UserID      = userID;
            TotalAmount = totalAmount;
            Date        = date;
        }
    }
}
