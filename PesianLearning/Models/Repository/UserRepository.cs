//using Models;
//using PesianLearning.Data;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Repository
//{
//    public class UserRepository: IDisposable
//    {
//        private ApplicationDbContext db = null;
//        public UserRepository()
//        {
//            db = new ApplicationDbContext();
//        }

//        public ApplicationUser GetUserByID(string UserID)
//        {
//            if (UserID == null)
//                return null;

//            var qUser = db.Users.Where(a => a.Id == UserID).SingleOrDefault();

//            return qUser ?? null;
//        }

//        ~UserRepository()
//        {
//            Dispose();
//        }

//        public void Dispose()
//        {

//        }
//    }
//}
