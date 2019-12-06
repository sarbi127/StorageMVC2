using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageMVC2.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly StorageMVC2Context _appDbContext;
        public ProductRepository(StorageMVC2Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProduct
        {
            get
            {
                return _appDbContext.Product;
            }
        }

        public int TotalValue()
        {

           // foreach (var pro in AllProduct)
                //var t = pro.Count * pro.Price;  

           return AllProduct.Sum( item => item.Price );
         
        }


    }
}
