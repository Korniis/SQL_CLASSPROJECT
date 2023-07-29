
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Service
{
    public class AthleteTableService : IService<AthleteTable>
    {
        public int Delete(AthleteTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"DECLARE @Id int, @Name nvarchar(max); 

                              SET @Id = [t].[Id]; 
                               SET @Name = [t].[Name]; 

                               DELETE FROM [AthleteTable] 
                             WHERE [Id] = @Id 
                                  AND [Name] = @Name;

                                SELECT @@ROWCOUNT; ";
                db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
                return db.SaveChanges();


            }
        }

        public int Insert(AthleteTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"INSERT INTO [AthleteTable] ([Id], [Name]) 
VALUES (@Id, @Name); 

SELECT @@ROWCOUNT; ";

                db.Entry(t).State = System.Data.Entity.EntityState.Added;
                return db.SaveChanges();


            }
        }
        public int Count()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @" SELECT COUNT(*) FROM [AthleteTable]; -- 返回记录数量";
                return db.AthleteTable.Count();

            }
        }

        public AthleteTable Select(int Id)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"SELECT * FROM [AthleteTable]
WHERE [AthleteMatchID] = @Id;";
                return db.AthleteTable.FirstOrDefault(item => item.AthleteMatchID == Id);
            }
        }

        public AthleteTable Select(string AthleteName)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"SELECT * FROM [AthleteTable]
WHERE [AthleteName] = @AthleteName";
                return db.AthleteTable.FirstOrDefault(item => item.AthleteName == AthleteName);
            }
        }


        public List<AthleteTable> Select()
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"SELECT * FROM [AthleteTable]
JOIN [MatchTable] ON [AthleteTable].[MatchId] = [MatchTable].[Id]
JOIN [ClassTable] ON [AthleteTable].[ClassId] = [ClassTable].[Id]
JOIN [RegistrationTable] ON [AthleteTable].[RegistrationId] = [RegistrationTable].[Id]";
                return db.AthleteTable.Include("MatchTable").Include("ClassTable").Include("RegistrationTable").ToList();

            }
        }

        public int Update(AthleteTable t)
        {
            using (SportsDBEntities db = new SportsDBEntities())
            {
                string sql = @"UPDATE [AthleteTable]
SET [Id] = @Id, [Name] = @Name -- 需要更新的列和对应的值
WHERE [AthleteMatchID] = @Id; -- 匹配记录的条件

SELECT @@ROWCOUNT; -- 返回受影响的行数";

                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();


            }
        }
        public int Update(List<AthleteTable> t)
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
