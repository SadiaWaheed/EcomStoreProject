﻿namespace EcomStoreProject.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; } 
        ICompanyRepository Company { get; } 
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
        IWishListRepository WishList { get; }
        IGenreRepository Genre { get; }
        IConfigurationRepository Configuration { get; }
        void Save();
    }
}
