using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class clsCategory
    {
        public static async Task<List<Category_DTO>> GetAllCategories()
        {
            return await dalCategory.GetAllCategories();
        }
    }
}
