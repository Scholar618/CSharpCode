using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDelegata
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFac = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFac.MakePizza);
            Func<Product> func2 = new Func<Product>(productFac.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1, log);
            Box box2 = wrapFactory.WrapProduct(func2, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}.Price is {2}!", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        // 模板方法实现委托
        public Box WrapProduct(Func<Product> getProduct, Action<Product> getLog)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if(product.Price > 20)
            {
                getLog(product);
            }
            box.Product = product;
            return box;
        }
    }
    
    //作用是委托一旦形成，上面几个类后续都可以不用变化，想要增加方法只需在ProductFactory里增加即可
    //提高代码复用性

    class ProductFactory
    { 
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 120;
            return product;
        }
    }

}
