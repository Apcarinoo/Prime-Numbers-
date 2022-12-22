using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
       int  n, Number1, Number2, sum =0 ;
       Console.WriteLine(" Please, Enter The Start Positive Number.. ");
       Number1=int.Parse(Console.ReadLine());
       Console.WriteLine("Please, Enter The Final Positive Number.. ");
       Number2=int.Parse(Console.ReadLine());
       n = Number1 + 1 ;
       while (n < Number2)
        { 
            for (int x =1 ; x<=n ; x++)
            { 
                if ((n % x) == 0 )
            sum+=x;
            }
            if (sum==n+1)
            Console.WriteLine(n);
            sum = 0;
            n++;
        }
     }
   }
 }