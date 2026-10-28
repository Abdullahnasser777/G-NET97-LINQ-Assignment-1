using static Assimgnment_Linq_01.ClassMethods;
using static LINQ.DataSources.Source;
namespace Assimgnment_Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01 
            //1. Get all products from the "Seafood" category. Print each product's name and price.

            //SeaFoodProducts();

            #endregion

            #region Question02
            ////2. Get a list of only the product names from ProductList. Print each name.

            //ProductNames();

            #endregion

            #region Question03
            ////3. Sort all products by UnitPrice (ascending). Print each  product's name and price.

            //ProductsSortByPrice();

            #endregion

            #region Question04
            ////4. Get all products where UnitPrice is between 10 and 30

            //ProductsBetween10And30();

            #endregion

            #region Question05
            ////5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //CondimentsInStock();

            #endregion

            #region Question06
            //6. Create a new anonymous type with three properties: 
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, 
            //otherwise "Out of Stock"
            //● Print the result.

            //ProductsStockInStatus();

            #endregion

            #region Question07
            //7. Print each product's name along with its position (1-based) 
            //in the list. Expected format: 1.Chai, 2.Chang, etc.

            //ProductsWithPosition();

            #endregion

            #region Question08
            //8. Sort ProductList by Category ascending, then within each 
            //category, sort by UnitPrice descending. 

            //SortByCategoryThenPrice();

            #endregion

            #region Question09
            //9. Get all products from the "Beverages" category, sorted by 
            //UnitsInStock descending. Print name and stock.

            //BeveragesByStock();

            #endregion

            #region Question10
            //10. Using QUERY SYNTAX with a compound from clause, list 
            //all orders placed in 1997 or later showing CustomerID and OrderDate.

            //OrdersFrom1997();

            #endregion

            #region Question11
            ////11. Show position number alongside ProductName

            //ProductNameWithIndex();

            #endregion

            #region Question12
            //12. Sort first by-word length and then by a 
            //case -insensitive sort of the words in an array. 
            //String[] Arr = { "Apple", "Abacus", "Branch", "Blueberry", "Clover", "Cherry" };

            //SortWordByLengthThenAlphe();

            #endregion

            #region Question13
            ////13. Create a list of all digits in the array whose second 
            ////letter is 'i' that is reversed from the order in the original array.

            //DigitsWithSecondLetteri();

            #endregion

        }
    }
}
