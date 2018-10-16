using Microsoft.Extensions.Logging.Console.Internal;
using PesianLearning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Repository
{
    public class MenuRepository: IDisposable
    {

        private ApplicationDbContext db = null;
        public MenuRepository()
        {
            db = new ApplicationDbContext();
        }


        public List<VmMenu> GetMenu(int id = 0)
        {
            try
            {
                var qMenu = (from a in db.Menus
                             where a.ParrentID == id
                             orderby a.Sort ascending
                             select new VmMenu
                             {
                                 ID = a.ID,
                                 ParrentID = a.ParrentID,
                                 Title = a.Title
                             }).ToList();

                return qMenu;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool HasChildMenu(int id)
        {
            try
            {
                var q = db.Menus.Where(a => a.ParrentID == id);
                if (q.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        ~MenuRepository()
        {
            Dispose();
        }

        public void Dispose()
        {

        }
    }
}

