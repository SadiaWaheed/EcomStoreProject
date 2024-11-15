﻿using EcomStoreProject.DataAccess.Data;
using EcomStoreProject.DataAccess.Repository.IRepository;

namespace EcomStoreProject.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
            WishList = new WishListRepository(_db);
            Genre = new GenreRepository(_db);
            Configuration = new ConfigurationRepository(_db);
        }
        public ICategoryRepository Category { get; private set;}
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }   
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IWishListRepository WishList { get; private set; }
        public IGenreRepository Genre { get; private set; }
        public IConfigurationRepository Configuration { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
