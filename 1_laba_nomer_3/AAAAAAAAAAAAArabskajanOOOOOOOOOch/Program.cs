// See https://aka.ms/new-console-template for more information
// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, World!");

            string st = "Hello, World!";
            string res = "";
            Console.WriteLine(st[0]);

            string[] list = { "Tom", "Bob", "Sam", "Kim", "Somas", "Bill", "Jo", "11", "20", "Mara", "Alla", "71", "jhjhjk", "54n3b5v", "786FG80" };

            Console.WriteLine();
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

           
            var selected = from p in list 
                                 where p.Length % 2 == 0       
                                 orderby p  
                                 select p;      

            var selected2 = from p in list 
                                 where p.Length % 2 != 0        
                                 orderby p  
                                 select p;

            foreach (string str in selected)
            {
                Console.WriteLine(str);
                res += str[0];
            }
            Console.WriteLine(res);
            foreach (string str in selected2)
            {
                Console.WriteLine(str);
                res += str[str.Length - 1];
            }
            Console.WriteLine(res);

            char[] sres = res.ToCharArray();
            var sres1 = from p in sres
                       where p != null    // перед                                
                       orderby p  // упорядочив
                       select p;
            Console.WriteLine();
            foreach (char ch in sres1)
            {
                Console.Write(ch);
            } 
  
     
 
            //Console.WriteLine(sres1);
            
           
            //var initials =  from i in list 
            //                where i.Length % 2 == 0 
            //                select i[0];
            //Console.WriteLine(initials);

            //var init2 = from i in list 
            //            where i.Length % 2 != 0 
            //            select i[i.Length - 1];
            //Console.WriteLine(init2);

            //var inits = res.OrderBy(l => l);


        } 
    }
}
