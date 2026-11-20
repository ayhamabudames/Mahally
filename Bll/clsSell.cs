using Bll.Utilities;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class clsSell
    {
        public static async Task<bool> InvoiceSell(List<Item_DTO> items)
        {
            return await dalSell.InvoiceSell(clsGlobal.CurrentUser.UserID, items);
        }
    }
}
