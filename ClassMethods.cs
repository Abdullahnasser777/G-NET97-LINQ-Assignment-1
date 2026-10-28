using static LINQ.DataSources.Source;

namespace Assimgnment_Linq_01
{
    public static class ClassMethods
    {
        #region Question01 
        //1. Get all products from the "Seafood" category. Print each product's name and price.
        public static void SeaFoodProducts()
        {
            Console.WriteLine("----- Q1 -----");
            var result = ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in result)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        }

        #endregion

        #region Question02
        ////2. Get a list of only the product names from ProductList. Print each name.
        public static void ProductNames()
        {
            Console.WriteLine("----- Q2 -----");
            var names = ProductList.Select(p => p.ProductName);
            foreach (var name in names)
                Console.WriteLine(name);
        }

        #endregion

        #region Question03
        ////3. Sort all products by UnitPrice (ascending). Print each  product's name and price.
        public static void ProductsSortByPrice()
        {
            Console.WriteLine("----- Q3 -----");
            var result = ProductList.OrderBy(p => p.UnitPrice);
            foreach (var p in result)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        }

        #endregion

        #region Question04
        ////4. Get all products where UnitPrice is between 10 and 30
        public static void ProductsBetween10And30()
        {
            Console.WriteLine("----- Q4 -----");
            var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var p in result)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
        }

        #endregion

        #region Question05
        ////5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.
        public static void CondimentsInStock()
        {
            Console.WriteLine("----- Q5 -----");
            var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            foreach (var p in result)
                Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
        }

        #endregion

        #region Question06
        //6. Create a new anonymous type with three properties: 
        //● Name → the product name
        //● Price → the unit price
        //● StockStatus → a string: "Available" if UnitsInStock > 0, 
        //otherwise "Out of Stock"
        //● Print the result.
        public static void ProductsStockInStatus()

        {
            Console.WriteLine("----- Q6 -----");
            var result = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
        }

        #endregion

        #region Question07
        //7. Print each product's name along with its position (1-based) 
        //in the list. Expected format: 1.Chai, 2.Chang, etc.
        public static void ProductsWithPosition()
        {
            Console.WriteLine("----- Q7 -----");
            var result = ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");
            foreach (var item in result)
                Console.WriteLine(item);
        }

        #endregion

        #region Question08
        //8. Sort ProductList by Category ascending, then within each 
        //category, sort by UnitPrice descending. 
        public static void SortByCategoryThenPrice()
        {
            Console.WriteLine("----- Q8 -----");
            var result = ProductList
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);
            foreach (var p in result)
                Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
        }

        #endregion

        #region Question09
        //9. Get all products from the "Beverages" category, sorted by 
        //UnitsInStock descending. Print name and stock.
        public static void BeveragesByStock()
        {
            Console.WriteLine("----- Q9 -----");
            var result = ProductList
                .Where(p => p.Category == "Beverages")
                .OrderByDescending(p => p.UnitsInStock);
            foreach (var p in result)
                Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
        }

        #endregion

        #region Question10
        //10. Using QUERY SYNTAX with a compound from clause, list 
        //all orders placed in 1997 or later showing CustomerID and OrderDate.
        public static void OrdersFrom1997()
        {
            Console.WriteLine("----- Q10 -----");
            var result = from c in CustomerList
                         from o in c.Orders
                         where o.OrderDate.Year >= 1997
                         select new { c.CustomerID, o.OrderDate };
            foreach (var item in result)
                Console.WriteLine($"{item.CustomerID} - {item.OrderDate:yyyy-MM-dd}");
        }

        #endregion

        #region Question11
        ////11. Show position number alongside ProductName
        public static void ProductNameWithIndex()
        {
            Console.WriteLine("----- Q11 -----");
            var result = ProductList.Select((p, i) => new { Index = i + 1, p.ProductName });
            foreach (var item in result)
                Console.WriteLine($"{item.Index} - {item.ProductName}");
        }

        #endregion

        #region Question12
        //12. Sort first by-word length and then by a 
        //case -insensitive sort of the words in an array. 
        //String[] Arr = { "Apple", "Abacus", "Branch", "Blueberry", "Clover", "Cherry" };
        public static void SortWordByLengthThenAlphe()

        {
            Console.WriteLine("----- Q12 -----");
            string[] Arr = { "Apple", "Abacus", "Branch", "Blueberry", "Clover", "Cherry" };

            var result = Arr
                .OrderBy(w => w.Length)
                .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var w in result)
                Console.WriteLine(w);
        }

        #endregion

        #region Question13
        ////13. Create a list of all digits in the array whose second 
        ////letter is 'i' that is reversed from the order in the original array.
        public static void DigitsWithSecondLetteri()

        {
            Console.WriteLine("----- Q13 -----");
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = Arr
                .Where(d => d.Length > 1 && d[1] == 'i')
                .Reverse();
            foreach (var d in result)
                Console.WriteLine(d);
        }

        #endregion

    }
}
