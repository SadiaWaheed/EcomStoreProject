using EcomStoreProject.DataAccess.Data;
using EcomStoreProject.DataAccess.Repository.IRepository;
using EcomStoreProject.Model;

namespace EcomStoreProject.DataAccess.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private ApplicationDbContext _db;
        public GenreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Genre obj)
        {
            _db.Update(obj);
        }
    }
}
