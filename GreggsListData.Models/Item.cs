using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreggsListData.Models
{
    public class Item
    {
        public int Id { get; set; }
            public int RegionId { get; set; }
            public virtual Region Region { get; set; }
        
            public int UserId { get; set; }
            public virtual User User { get; set; }

        public string Name { get; set; }
        public DateTime DateListed { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
