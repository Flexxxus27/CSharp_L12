namespace CSharp_L12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            catalog.AddProduct(new Product { Id = 1, Name = "Product 1", Price = 10.5, Category = "Category 1" });
            catalog.AddProduct(new Product { Id = 2, Name = "Product 2", Price = 20.75, Category = "Category 2" });
            catalog.SaveToJson("products.json");
            catalog.LoadFromJson("products.json");
            foreach(var i in catalog.products)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }

            catalog.SaveToXml("products.xml");
            catalog.LoadFromXml("products.xml");
            foreach (var i in catalog.products)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }
            //Фильтр по категории
            IEnumerable<Product> filteredProducts = catalog.FilterProductsByCategory("Category 1");
            foreach(var i in filteredProducts)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }

            //сортировка по цене 
            IEnumerable<Product> sortedProducts = catalog.SortProductsByPrice();
            foreach (var i in sortedProducts)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }



        }


    }
}




