using GreggsList.Adapters.Interface;
using GreggsList.Models;
using GreggsListData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreggsList.Adapters.Data
{
    public class GreggsListDataAdapter : IGreggsListAdapter 
    {
        public GLHPViewModel GetGLHP() {
            GLHPViewModel area = new GLHPViewModel();
            GreggsListContext db = new GreggsListContext();
            area.Regions = db.Regions.ToList();
            area.States = db.States.ToList();
            return area;
        }
        public GLRPViewModel GetGLRP(int id, string itemSearch)
        {
            GLRPViewModel stuff = new GLRPViewModel();
            GLRPViewModel searchedItem = new GLRPViewModel();
            GreggsListContext db = new GreggsListContext();
            
            
            
            if (!String.IsNullOrEmpty(itemSearch))
            {
                searchedItem.SelectRegion = db.Regions.Find(id);
                searchedItem.Items = db.Items.Where(i => i.Region.Id == id).Where(i => i.Name.Contains(itemSearch)).ToList();
                return searchedItem;
            }
            else 
            {
                stuff.Items = db.Items.Where(i => i.Region.Id == id).ToList();
                stuff.SelectRegion = db.Regions.Find(id);
                return stuff;
            }
            
            
        }
        
        public string GetRegionsViewBag(int id)
        {
            GreggsListContext db =new GreggsListContext();
            string bag = db.Regions.Where(r => r.Id == id).Select(r => r.Name).First();
            return bag;
        }
        
    }
}