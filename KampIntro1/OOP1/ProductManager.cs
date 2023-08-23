using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product) //101
        {
            product.ProductName = "Masa";
        }

        public void BiseyYap(int sayi)
        {
           sayi = 99;
        }

        
    }
}
