using Microsoft.EntityFrameworkCore;
using PesianLearning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Repository
{
    public class SliderRepository : IDisposable
    {
        private ApplicationDbContext db = null;
        public SliderRepository()
        {
            db = new ApplicationDbContext();
        }
        public List<VmSlider> GetSlider()
        {
            return db.Sliders
                .Include(s => s.Course).ThenInclude(m => m.Movies)
                .Include(s => s.Course).ThenInclude(m => m.professor).ThenInclude(a=>a.ApplicationUser).ThenInclude(m=>m.ImageProfile)
                .Select(Slider => new VmSlider
                {
                    ID = Slider.ID,
                    Title = Slider.Course.TitleFa,
                    Professor = Slider.Course.professor.ApplicationUser.Name,
                    Link = Slider.Link,
                    Number = Slider.Course.Movies.Count,
                    ImgUrl = Slider.Course.professor.ApplicationUser.ImageProfile.Server.Url.TrimEnd('/') + "/" + Slider.Course.professor.ApplicationUser.ImageProfile.FileName,
                    Alt = Slider.Course.professor.ApplicationUser.ImageProfile.Alt
                }
            ).OrderBy(O => O.Sort).ToList();
        }
        ~SliderRepository()
        {
            Dispose();
        }

        public void Dispose()
        {

        }
    }
}
