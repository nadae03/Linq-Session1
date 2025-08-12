namespace Linq_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Implicitly Typed Local Variable [var, dynamic]
            //var Data;
            //var Data1 = 55.6;
            //Data1 = 6;
            //Data1 = null;

            //////
            //dynamic Data;
            //dynamic Data1 = 55.6;
            //Data1 = 6;
            //Data1 = null;
            #endregion
            #region Extension Method 
            //int x = 12345;
            //int y=IntExtensions.Reverse(x);
            //Console.WriteLine(y);
            //y=x.Reverse();//syntax suger
            //Console.WriteLine(y);
            #endregion
            #region Anonymous Type
            //var Employee1 = new { Id = 10, Name = "Nada", Salary = 20000 };
            //Console.WriteLine(Employee1.GetType());
            //Console.WriteLine(Employee1);
            ////Employee1.Salary = 4000;
            //var Employee2 = Employee1 with { Id = 20 };
            //Console.WriteLine(Employee2);
            //var product = new { ProductID = 102, ProductName = "Meat" };
            //Console.WriteLine(product.GetType().Name);
            #endregion
            #region What Is Linq
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> Oddnumbers = numbers.Where(n => n % 2 == 1).ToList();
            //foreach(var odd in Oddnumbers)
            //{
            //    Console.WriteLine(odd);
            //}
            #endregion
            #region LINQ Syntax
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            #region 1. Fluent Syntax
            #region 1.1 Calling LINQ Operators as Static Methods through Enumerable Class 
            //var result = Enumerable.Where(numbers, n => n % 2 == 1);
            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region 1.2 Calling LINQ Operators as Extension Methods [RECOMMENDED]
            //var result = numbers.Where( n => n % 2 == 1);
            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #endregion
            #region 2. Query Syntax
            //var oddnumbers=from n in numbers
            //               where n%2==1
            //               select n;
            #endregion
            #endregion
            #region Linq Execution
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            #region  1. Deffered Execution 
            //var Oddnumbers = numbers.Where(n => n % 2 == 1);
            //foreach (int n in Oddnumbers)
            //{
            //    Console.WriteLine(n);
            //}
            //numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            //Console.WriteLine("After AddRange ");
            //foreach (int n in Oddnumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region  2. Immediate Execution
            //var Oddnumbers = numbers.Where(n => n % 2 == 1).ToList();
            //foreach (int n in Oddnumbers)
            //{
            //    Console.WriteLine(n);
            //}
            //numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            //Console.WriteLine("After AddRange ");
            //foreach (int n in Oddnumbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #endregion
            #region  Filtration (Restrictions) Operator 
            #region fluent Syntax
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0 && p.Category == "Meat/Poultry");
            #endregion
            #region Query Syntax
            //var result=from n in ListGenerator.ProductsList
            //           where n.UnitsInStock == 0
            //           select n;
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
            //             select p;

            #endregion
            #region Indexed 
            //var result = ListGenerator.ProductsList.Where((p, index) => p.UnitsInStock == 0 && index < 10);

            #endregion
            #endregion
            #endregion

            #region Assignment
            #region 1. Find all products that are out of stock.
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("All products that are out of stock");
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = from n in ListGenerator.ProductsList
            //             where n.UnitsInStock > 0 && n.UnitPrice > 3.00M
            //             select n;
            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //}


            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr
            //.Select((name, val) => new { Value = val, Name = name })
            //.Where(x => x.Name.Length < x.Value)
            //.Select(x => x.Name);

            //foreach (var x in result)
            //    Console.WriteLine(x);
            #endregion
            #endregion

            #region MyRegion

            #endregion

        }
    }
}
