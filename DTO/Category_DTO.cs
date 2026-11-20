using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category_DTO
    {
        public int CategoryID { get; set; }
        public string Title { get; set; }

        public Category_DTO(int categoryID, string title)
        {
            CategoryID = categoryID;
            Title = title;
        }
    }
}
