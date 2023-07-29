using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class ClassTableService:IService<ClassTable>
    {
        public int Delete(ClassTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(ClassTable t)
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

                return db.ClassTable.Count();

            }
        }

        public ClassTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.ClassTable.FirstOrDefault(item => item.ClassID == Id);
            }
        }

        public ClassTable Select(string MatchName)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.ClassTable.FirstOrDefault(item => item.ClassName == MatchName);
            }
        }


        public List<ClassTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                return db.ClassTable.ToList();

            }
        }

        public int Update(ClassTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
        public int Update(List<ClassTable> t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {

                db.BulkUpdate(t);

                db.BulkSaveChanges();
                return 0;


            }
        }
    }
}
