using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class UserInfoService : IService<UserInfo>
    {
        public int Delete(UserInfo t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            { 
            
            db.Entry(t).State=System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();
            
            
            }
        }

        public int Insert(UserInfo t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();


            }
        }
        public int Count ( )
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.UserInfo.Count();

            }
        }

        public UserInfo Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.UserInfo.FirstOrDefault(item => item.Id == Id);
            }
        }

        public UserInfo Select(string Name)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.UserInfo.FirstOrDefault(item => item.Name == Name);
            }
        }

        public List<UserInfo> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.UserInfo.ToList();

            }
        }

        public int Update(UserInfo t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
