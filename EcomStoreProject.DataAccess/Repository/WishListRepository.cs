using EcomStoreProject.DataAccess.Data;
using EcomStoreProject.DataAccess.Repository.IRepository;
using EcomStoreProject.Model;

namespace EcomStoreProject.DataAccess.Repository
{
    public class WishListRepository:Repository<WishList>,IWishListRepository
    {
        private ApplicationDbContext _db;
        public WishListRepository(ApplicationDbContext db) : base(db)
        {
            _db= db;
        }

    }
}
