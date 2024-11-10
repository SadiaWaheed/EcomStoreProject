using EcomStoreProject.Model;

namespace EcomStoreProject.DataAccess.Repository.IRepository
{
    public interface IConfigurationRepository:IRepository<Configurations>
    {
        void Update(Configurations obj);
    }
}
