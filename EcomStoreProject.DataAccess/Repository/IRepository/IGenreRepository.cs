using EcomStoreProject.Model;

namespace EcomStoreProject.DataAccess.Repository.IRepository
{
    public interface IGenreRepository :IRepository<Genre>
    {
        void Update(Genre obj);
    }
}
