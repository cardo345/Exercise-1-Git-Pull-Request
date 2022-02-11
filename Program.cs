using System;
using System.Linq;
using System.Collections.Generic;

//Repository https://github.com/cardo345/Exercise-1-Git-Pull-Request

namespace Exercise1
{
    
    public class Class1
    {
        public string Comparison(string a, string b)
        {
            string firstWord = a;
            string secondWord = b;
            string wordComparison;
            if (firstWord.Equals(secondWord))
            {
                wordComparison = "Strings are the same ";
                return wordComparison;
            }
            wordComparison = "Strings are not the same";
            return wordComparison;
        }
        public void VerifyBiggestNumber(int[] array)
        {
            int Biggestnum = array.Max();
            Console.WriteLine("The Biggest numer is " + Biggestnum);
        }
        public void SortList(string[] array)
        {
            var nameList = new List<String>();
            nameList.AddRange(array);
            Console.WriteLine("List in unsorted order: ");
            foreach (var name in nameList)
                Console.Write("   {0}", name);
            Console.WriteLine(Environment.NewLine);
            nameList.Sort();
            Console.WriteLine("List in asc sorted order: ");
            foreach (var name in nameList)
                Console.Write("   {0}", name);
            Console.WriteLine(Environment.NewLine);
            nameList.Sort();
            nameList.Reverse();
            Console.WriteLine("List in desc sorted order: ");
            foreach (var name in nameList)
                Console.Write("   {0}", name);
        }
        public int CountStringLength(string word)
        {
            int x = word.Length;
            Console.WriteLine(Environment.NewLine);
            return x;
        }
    }
    public class Program
    {
        static void Main()
        {
            var x = new Class1();
            string a;
            string b;
            string word = "Hello";
            int[] array1 = new int[] { 1, 13, 10, 7, 19};
            string[] array2 = new string[] { "Hello", "My", "Name", "is", "Juan" };
            Console.WriteLine("Type in First Word:");
            a = Console.ReadLine();
            Console.WriteLine("Type in Second Word:");
            b = Console.ReadLine();
            Console.WriteLine(x.Comparison(a , b));
            x.VerifyBiggestNumber(array1);
            x.SortList(array2);
            Console.WriteLine("The word is "+ x.CountStringLength(word) + " Characters Long");
        }
    }
}
