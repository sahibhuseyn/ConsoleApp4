using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var param = "Salam heci naber?";

            var punctuation = param.Where(Char.IsPunctuation).Distinct().ToArray();
            var nwords = param.Split().Select(x => x.Trim(punctuation));

            Console.WriteLine(param.Substring(0,5)+"\n"+param.Substring(6,5)+"\n"+param.Substring(11,6)+"\n");
            Console.WriteLine(nwords);

            string[] words = param.Split(' ');
            foreach (string word in words)
            {  
                Console.WriteLine(word);
            }*/
            //string[] daysofweek =
            //{
            //    "sunday",
            //    "monday",
            //    "tuesday",
            //    "wednesday",
            //    "thursday",
            //    "friday",
            //    "saturday"
            //};
            //for (var i = 0; i < daysofweek.length; i++)
            //{
            //    console.writeline(daysofweek[i]);
            //}
            //char[] arr = { 'g', 'h', 'f', 'a', 'f', 'h','g'};
            //bool symetric = true;
            //for (int i = 0; i < arr.length - i - 1; ++i)
            //{
            //    symetric = symetric & arr[i] == arr[arr.length - i - 1];
            //}

            //console.writeline("symetric?  {0}", symetric);

            //string[] Arr =
            //{
            //    "one",
            //    "two",
            //    "three",
            //    "four",
            //    "five"
            //};
            //for (var i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine("elem[{0}]={1}",i,Arr[i]);
            //}


            //string[] Arr =
            //{
            //    "one",
            //    "two",
            //    "three",
            //    "four",
            //    "five"
            //};
            //for (var i = Arr.Length - 1; i > 0; i--)
            //{
            //    Console.WriteLine("elem[{0}]={1}", i, Arr[i]);
            //}

            //string[] Arr =
            //{
            //    "one",
            //    "two",
            //    "three",
            //    "four",
            //    "five"
            //};
            //for (var i = Arr.Length - 1; i > 0; i--)
            //{
            //    Console.WriteLine("elem[{0}]={1}", i/2, Arr[i]);
            //}
            string str = "salam necesen ne var ne yox?";
            var letters = str.Split();

            foreach (var letter in letters)
            {
                if (letter.Contains('a'))
                {
                    var change = str.Replace('a','x') ;
                    Console.WriteLine(change);
                }
             }
                //string str = "salam necesen ne var ne yox?";
                //char Contains = 'a';

                //int i = str.IndexOf('a');

                //Console.WriteLine("found '{0}' in '{1}' ", Contains, str);
            }
    }
}