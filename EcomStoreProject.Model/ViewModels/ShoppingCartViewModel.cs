﻿namespace EcomStoreProject.Model.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<ShoppingCart>? ListCart { get; set; }
        public OrderHeader? OrderHeader { get; set; }
    }
}
