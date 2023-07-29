using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class RegistrationTableService:IService<RegistrationTable>
    {
        public int Delete(RegistrationTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(RegistrationTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Added;

                return db.SaveChanges();


            }
        }
        public int Count()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RegistrationTable.Count();

            }
        }

        public RegistrationTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RegistrationTable.FirstOrDefault(item => item.SNO == Id);
            }
        }


        public RegistrationTable Select(string AthleteName)
        {
            return null;
        }

        public List<RegistrationTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.RegistrationTable.Include("ClassTable").ToList();

            }
        }

        public int Update(RegistrationTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
    }
}
