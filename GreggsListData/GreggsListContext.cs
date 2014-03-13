using GreggsListData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreggsListData
{
    public class GreggsListContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<ContactMessage> ContactMembers { get; set; }
    }
}
