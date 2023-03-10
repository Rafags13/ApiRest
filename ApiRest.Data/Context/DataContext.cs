using ApiRest.Data.DataConfig;
using ApiRest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRest.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Courses>(new CoursesConfiguration().Configure);
            base.OnModelCreating(builder);
        } 
    }
}
