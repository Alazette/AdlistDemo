using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreggsListData.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        

        public virtual List<Item> Items { get; set; }

    }
}
