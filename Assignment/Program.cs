using Assignment.Data;
using System.Data.SqlTypes;
using  static Assigment. ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            var custWashington = from c in CustomersList.Where(c => c.City== "Washington")
                                 from o in c.Orders
                                 .Take(3)
                                 select o;


            //. Get all but the first 2 orders from customers in Washington
            var all = from c in CustomersList.Where(c => c.City == "Washington")
                      from o in c.Orders
                      .Skip(2)
                      select o;
            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var p = numbers.TakeWhile((value,index)=> value>index ).ToArray();


            //4.Get the elements of the array starting from the first element divisible by 3.
            int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var d = Numbers.SkipWhile(n=>n%3!=0);

            //5. Get the elements of the array starting from the first element less than its position.
            int[] numberS = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var s = numberS.SkipWhile((value , index)=>value>index);



            #endregion
            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt
            //into Array of String First) contain the substring 'ei'.

            string path = "D:\\Route.net course\\5_Linq\\Session 03\\Assignment\\Day03\\Assignment\\dictionary_english.txt";


            var DictionaryArray= File.ReadAllText(path).ToArray();

            var result = DictionaryArray.Any(p => p.Equals("ei"));




            //2.  Return a grouped a list of products only for categories that have
            //at least one product that is out of stock..

            var v = ProductsList.Any(p=>p.UnitsInStock==0);


            //3.  Return a grouped a list of products only for categories that
            //have all of their products in stock.


            

            #endregion

        }
    }
}
