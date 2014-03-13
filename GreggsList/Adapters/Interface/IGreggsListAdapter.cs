using GreggsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreggsList.Adapters.Interface
{
    public interface IGreggsListAdapter
    {
        GLHPViewModel GetGLHP();
        GLRPViewModel GetGLRP(int id, string itemSearch);
        string GetRegionsViewBag(int id);
    }
}
