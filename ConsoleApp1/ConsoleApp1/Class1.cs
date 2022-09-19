using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string shipping { get; set; }

        public List<Class2> products;

        public decimal total => products.Count;
        public decimal totalPrice { get; set; }

        public Class1()
        {
            this.products = new List<Class2>();
        }

        public void addProduct(Class2 product)
        {
            int x = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].code.Equals(product.code))
                {
                    x += 1;
                    products[i].quantity += product.quantity;
                }

            }
            if (x == 0)
            {
                this.products.Add(product);
            }
        }
        public void totalP()
        {
            for (int i = 0; i < products.Count; i++)
            {
                for (int j = 0; j < products[i].quantity; j++)
                {
                    totalPrice += products[i].price - (products[i].price * products[i].discount / 100);
                }
            }
        }
    }
}