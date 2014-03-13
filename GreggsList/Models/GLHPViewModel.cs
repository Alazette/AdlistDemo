using GreggsListData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreggsList.Models
{
    public class GLHPViewModel
    {
        public List<State> States { get; set; }
        public List<Region> Regions { get; set; }
    }
}