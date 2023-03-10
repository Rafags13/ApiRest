

using ApiRest.Data.Context;
using ApiRest.Domain.Entities;
using ApiRest.Repositories.Base;
using ApiRest.Repositories.Interface;

namespace ApiRest.Repositories.Repository
{
    public class CoursesRepository : BaseRepository<Courses>, ICoursesRepository
    {
        public CoursesRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
