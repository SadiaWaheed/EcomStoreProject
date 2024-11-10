using EcomStoreProject.DataAccess.Data;
using EcomStoreProject.DataAccess.Repository.IRepository;
using EcomStoreProject.Model;

namespace EcomStoreProject.DataAccess.Repository
{
    public class ApplicationUserRepository:Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
    }
}
