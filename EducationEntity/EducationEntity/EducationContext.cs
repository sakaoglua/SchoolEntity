using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationEntity
{
    public class EducationContext:DbContext
    {
        public DbSet<School> Schools { get; set; }
    }
}
