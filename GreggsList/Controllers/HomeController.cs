using GreggsList.Adapters.Data;
using GreggsList.Adapters.Interface;
using GreggsList.Models;
using GreggsListData;
using GreggsListData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreggsList.Controllers
{
    public class HomeController : Controller
    {
        private IGreggsListAdapter _adapter;
        public HomeController()
        {
            _adapter = new GreggsListDataAdapter();
        }
        public ActionResult Index()
        {
            GLHPViewModel area = _adapter.GetGLHP();
            return View(area);
        }
        [HttpGet]
        public ActionResult RegionsPage(int id, string itemSearch)
        {
            ViewBag.Title = _adapter.GetRegionsViewBag(id);
            GLRPViewModel stuff = _adapter.GetGLRP(id, null);
            if (!String.IsNullOrEmpty(itemSearch))
            {
                GLRPViewModel searchedItem = _adapter.GetGLRP(id, itemSearch);
                return View(searchedItem);
            }
            else
            {
                return View(stuff);
            }
            
        }
        [HttpGet]
        public ActionResult ItemsPage(int id)
        {
            Item thing = new Item();
            GreggsListContext db = new GreggsListContext();
            thing = db.Items.Find(id);
            ViewBag.Title = db.Items.Where(i => i.Id == id).Select(i => i.Name).First();

            return View(thing);
        }
        [HttpGet]
        public ActionResult ContactMemberPage (int id)
        {
            GreggsListContext db = new GreggsListContext();
            Item ItemContact = db.Items.Find(id);
            return View(ItemContact);
        }
        [HttpPost]
        public ActionResult ContactMemberPage(int UserId, int MessageId, string Title, string Body)
        {
            
            ContactMessage message = new ContactMessage();
            message.UserId = UserId;
            message.Title = Title;
            message.Body = Body;
            GreggsListContext db = new GreggsListContext();
            db.ContactMembers.Create();
            db.ContactMembers.Add(message);
            db.SaveChanges();
            
                return RedirectToAction("ItemsPage" + "/" + MessageId);


        }
        [HttpGet]
        public ActionResult CreatePost()
        {
            
            GLCPViewModel all = new GLCPViewModel();
            all.Regions = _adapter.GetGLHP().Regions;
            all.States = _adapter.GetGLHP().States;
            return View(all);
        }
        [HttpPost]
        public ActionResult CreatePost(string UserName, string Email, string ItemName, string Description, int Price, int Region)
        {
            GreggsListContext db = new GreggsListContext();
            Item newItem = db.Items.Create();
            if (null != db.Users.Where(u => u.UserName == UserName).FirstOrDefault()) 
            {
                newItem.Name = ItemName;
                newItem.DateListed = DateTime.Now;
                newItem.RegionId = Region;
                newItem.UserId = db.Users.Where(u => u.UserName == UserName).FirstOrDefault().Id;
                newItem.Description = Description;
                newItem.Price = Price;

                db.Items.Add(newItem);
                db.SaveChanges();
            }
            else
            {
                User newUser = db.Users.Create();
                newUser.UserName = UserName;
                newUser.Address = Email;

                db.Users.Add(newUser);
                db.SaveChanges();

                newItem.Name = ItemName;
                newItem.DateListed = DateTime.Now;
                newItem.RegionId = Region;
                newItem.UserId = db.Users.Where(u => u.UserName == UserName).FirstOrDefault().Id;
                newItem.Description = Description;
                newItem.Price = Price;

                db.Items.Add(newItem);
                db.SaveChanges();


            }
            return RedirectToAction("Index");
        }
        
    }
}