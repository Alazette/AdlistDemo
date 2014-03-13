using GreggsListData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreggsList.Models
{
    public class GLRPViewModel
    {
        public Region SelectRegion { get; set; }
        public List<Item> Items { get; set; }
    }
}