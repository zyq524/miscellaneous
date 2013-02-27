using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public class FactoryPattern
    {
        public interface IProduct
        {
            string ShipFrom();
        }

        class ProductA : IProduct
        {
            public string ShipFrom()
            {
                return " from South Africa";
            }
        }

        class ProductB : IProduct
        {
            public string ShipFrom()
            {
                return " from Spain";
            }
        }

        class DefaultProduct : IProduct
        {
            public string ShipFrom()
            {
                return "not available";
            }
        }

        public class Creator
        {
            public IProduct Create(int month)
            {
                if (month >= 4 && month <= 11)
                {
                    return new ProductA();
                }
                else if (month == 1 || month == 2 || month == 12)
                {
                    return new ProductB();
                }
                else
                {
                    return new DefaultProduct();
                }
            }
        }
    }
}
