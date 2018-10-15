//using PesianLearning.Data;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using ViewModel;

//namespace Repository
//{
//    public class SliderRepository: IDisposable
//    {
//        private ApplicationDbContext db = null;
//        public SliderRepository()
//        {
//            db = new ApplicationDbContext();
//        }

//        public List<VmSlider> GetSlides()
//        {
//            List<VmSlider> LstSlides = new List<VmSlider>();

//            var qSlide = db.Slider
//                    .OrderBy(a => a.Sort)
//                    .Include(a => a.Image)
//                    .ThenInclude(a => a.Server)
//                    .ToList();

//            foreach (var item in qSlide) 
//            {
//                VmSlider vm = new VmSlider();
//                vm.ID = item.ID;
//                vm.Link = item.Link;
//                vm.Title = item.Title;
//                vm.ImgUrl =  "/" + item.Image.Server.Path.Trim(new char[] { '/' }) + "/" + item.Image.FileName;
//                LstSlides.Add(vm);
//            }

//            return LstSlides;

//        }


//        ~SliderRepository()
//        {
//            Dispose(true);
//        }

//        public void Dispose()
//        {
//            db.Dispose();
//        }

//        public void Dispose(bool Dis)
//        {
//            if (Dis)
//            {
//                Dispose();
//            }
//        }
//    }
//}

