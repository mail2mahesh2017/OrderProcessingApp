using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.OrderProcessingClass
{
    public class OrderProcessor
    {
        public static Product ConvertInputToType(string[] input)
        {
            ProductTypes type;
            try
            {
                type = (ProductTypes)Enum.Parse(typeof(ProductTypes), input[0], ignoreCase: true);
            }
            catch (Exception e)
            {
                type = ProductTypes.Other;
            }
            Product product;
            string name = input.Length > 1 ? string.Join(' ', input, 1, input.Length - 1) : string.Empty;
            switch (type)
            {
                case ProductTypes.Membership:
                    {
                        product = new Membership();
                        break;
                    }
                case ProductTypes.Upgrade:
                    {
                        product = new Upgrade();
                        break;
                    }
                case ProductTypes.Video:
                    {
                        product = new Video(name);
                        break;
                    }
                case ProductTypes.Book:
                    {
                        product = new Book(name);
                        break;
                    }
                case ProductTypes.Other:
                default:
                    {
                        product = new Other(name);
                        break;
                    }
            }
            return product;
        }
    }
}
