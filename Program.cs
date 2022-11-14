using System;
using testLib;
namespace std
{
    class Program
    {
        public static void Main(string[] args){
            int a = 10;
            int b = 11;
            

            Console.WriteLine(Sum.AddOperator(12,12));
            Console.WriteLine(Sum.MinusOperator(12,2));
            Console.WriteLine(Sum.TimeOperator(5,6));
            Console.WriteLine(Sum.DivOperator(5,6));

        }

        
        // public static int Sum(int a, int b){
        //     return a + b;
        // }
    }
}