//using Models;
//using PesianLearning.Data;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

//namespace Repository
//{
//    public class ImgRepository: IDisposable
//    {
//        private ApplicationDbContext db = null;
//        public ImgRepository()
//        {
//            db = new ApplicationDbContext();
//        }

//        public Image GetImageByID(int id)
//        {
//            var qImg = db.Images.Where(a => a.ID == id)
//                 .Include(a => a.Server)
//                 .SingleOrDefault();

//            return qImg ?? null;
//        }

//        public List<Image> GetImageByProductID(int ProductID)
//        {
//            var qImg = db.Images.Where(a => a.ProductID == ProductID)
//                 .Include(a => a.Server)
//                 .OrderByDescending(a => a.ID)
//                 .ToList();
//            //.FirstOrDefault();

//            return qImg;
//        }

//        ~ImgRepository()
//        {
//            Dispose(true);
//        }

//        public void Dispose()
//        {

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

