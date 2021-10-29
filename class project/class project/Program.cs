using System;

namespace class_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Shampoo",
                BrandName = "Elidor",
                Price = 6
            };
            Product product2 = new Product
            {
                Name = "Rice",
                BrandName = "Sultan",
                Price = 5
            };
            Product product3 = new Product
            {
                Name = "Oil",
                BrandName = "Final",
                Price = 3.5
            };
            double minPrice = 3.5;
            double maxPrice = 6;

            Product[] product = new Product[] { product1, product2, product3 };
            foreach (var item in metod(product, minPrice, maxPrice))
            {
                Console.WriteLine("Mehsulun Qiymeti: " + item.Price);
                Console.WriteLine("Mehsulun Adi: " + item.Name);
                Console.WriteLine("Mehsulun BrandName: " + item.BrandName);
            }
            Vehicle vehicle1 = new Vehicle()
            {
                Name = "Toyota",
                Color = "Black",
            };

            Car car1 = new Car()
            {
                Color = "White",
                Name = "Mercedes",
                Brand = "SLK200",
                Model = "Local"
            };

            Console.WriteLine($"Vehicle Adi: {vehicle1.Name}");
            Console.WriteLine($"Vehicle Rengi: {vehicle1.Color}");
            Console.WriteLine($"Car Reng: {car1.Color}");
            Console.WriteLine($"Car Ad: {car1.Name}");
            Console.WriteLine($"Car Marka: {car1.Brand}");
            Console.WriteLine($"Car Model: {car1.Model}");

        }
        static Product[] metod(Product[] product, double minPrice, double maxPrice)
        {
            int counter = 0;
            for (int i = 0; i < product.Length; i++)
            {
                if (minPrice < product[i].Price && product[i].Price < maxPrice)
                {
                    counter++;
                }
            }
            Product[] Mehsullar = new Product[counter]; int a = 0;
            for (int i = 0; i < product.Length; i++)
            {
                if (minPrice < product[i].Price && product[i].Price < maxPrice)
                {
                    Mehsullar[a] = product[i];
                    a++;
                }
            }
            return Mehsullar;
        }
    }
    }

