using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreggsListData.Models
{
    public class Region
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public string Name { get; set; }


        public virtual List<Item> Items { get; set; }

    }
}
