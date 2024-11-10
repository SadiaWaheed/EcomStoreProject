using EcomStoreProject.DataAccess.Data;
using EcomStoreProject.DataAccess.Repository.IRepository;
using EcomStoreProject.Model;
using Microsoft.Extensions.Configuration;

namespace EcomStoreProject.DataAccess.Repository
{
    public class ConfigurationRepository : Repository<Configurations>, IConfigurationRepository
    {
        private ApplicationDbContext _db;
        public ConfigurationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Configurations obj)
        {
            _db.Update(obj);
        }
    }
}
