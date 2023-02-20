using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationEntity
{
    public class SchoolDal
    {
        public List<School> GetAll()
        {
            using (EducationContext context = new EducationContext())
            {
                return context.Schools.ToList();
            }
        }
        
        public void Add(School school)
        {
            using (EducationContext context = new EducationContext())
            {
                //context.Schools.Add(school);
                var entity = context.Entry(school);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(School school)
        {
            using (EducationContext context = new EducationContext())
            {
                //context.Schools.Add(school);
                var entity = context.Entry(school);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(School school)
        {
            using (EducationContext context = new EducationContext())
            {
                //context.Schools.Add(school);
                var entity = context.Entry(school);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}
