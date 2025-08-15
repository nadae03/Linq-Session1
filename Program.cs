namespace Linq_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session1
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
            var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            Console.WriteLine("All products that are out of stock");
            foreach (var unit in result)
            {
                Console.WriteLine(unit);
            }

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
            #endregion
            #region Session2
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ProductsList.First(X => X.UnitsInStock ==0);
            //Console.WriteLine(result);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductsList.FirstOrDefault(X => X.UnitPrice > 1000);
            //var result=(from P in ProductsList
            //           where P.UnitPrice>1000
            //           select P).FirstOrDefault();
            //Console.WriteLine(result?.ProductName?? "NotFound");

            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where(X=>X>5).Skip(1).First();
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Count(X=>X%2==1);
            //Console.WriteLine(result);


            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var result = CustomersList
            //.Select(C => new
            //{
            //    C.CustomerName,
            //    CountOfOrders=C.Orders.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region 3. Return a list of categories and how many products each has
            //var result = ProductsList
            //    .Select(P => P.Category)
            //    .Distinct()
            //    .Select(C => new
            //    {
            //       Category = C,
            //       CountOfProducts = ProductsList.Count(P => P.Category == C)
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int result = Arr.Sum();
            //Console.WriteLine(result);


            #endregion
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = words.Sum(X=>X.Length);
            //Console.WriteLine(result);

            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result=words.Min(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result=words.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result=words.Average(x => x.Length);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var Result=ProductsList.OrderBy(P=>P.ProductName);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(A => A, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach(var item in Result) 
            //    Console.WriteLine(item);
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);
            //var Result= from P in ProductsList
            //            orderby P.UnitsInStock descending
            //            select P;
            //foreach (var Product in Result)
            //    Console.WriteLine(Product);
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result= Arr.OrderBy(X=>X.Length).ThenBy(X=>X);
            //foreach(var X in Result) 
            //    Console.WriteLine(X);
            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A=>A,StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach(string str in Result) 
            //    Console.WriteLine(str);
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductsList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var Item in Result) 
            //    Console.WriteLine(Item);
            #endregion
            #region 7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderByDescending(A => A.Length).ThenByDescending(A => A, StringComparer.OrdinalIgnoreCase);
            //foreach (string str in Result)
            //    Console.WriteLine(str);

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result = Arr.Where(S => S[1] == 'i').Reverse();
            //foreach (var S in Result) 
            //    Console.WriteLine(S);
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var Result = ProductsList.Select(X => X.ProductName);
            //foreach(var result in Result)
            //    Console.WriteLine(result);
            #endregion
            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(X => new
            //{
            //    UpperCase = X.ToUpper(),
            //    LowereCase = X.ToLower(),
            //});
            //foreach (var word in Result)
            //    Console.WriteLine(word);
            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ProductsList.Select(X => new
            //{
            //    X.ProductID,
            //    X.ProductName,                
            //    Price = X.UnitPrice
            //});
            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion
            #region 4.Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((X, I) => X == I);
            //foreach ( var X in Result) 
            //    Console.WriteLine(X);


            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result=from A in numbersA
            //           from B in numbersB
            //           where(A<B)
            //           select new { A, B };
            //foreach(var I in Result)
            //    Console.WriteLine($"{I.A} Is Less Than {I.B}");


            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            //var Result = CustomersList.SelectMany(X => X.Orders.Where(O => O.Total < 500.00m) );
            //foreach ( var O in Result ) 
            //    Console.WriteLine( O);
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var Result = CustomersList.SelectMany(C => C.Orders.Where(O => O.OrderDate.Year >= 1998));
            //foreach (var O in Result) 
            //    Console.WriteLine(O);
            #endregion
            #endregion
            #endregion

        }
    }
}
