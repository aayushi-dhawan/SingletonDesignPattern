using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            Singleton.Instance.Num1 = 10;  
            Singleton.Instance.Num2 = 5;  
            Console.WriteLine("Addition : " + Singleton.Instance.Addition());  
            Console.WriteLine("Subtraction : " + Singleton.Instance.Subtraction());  
            Console.WriteLine("Multiplication : " + Singleton.Instance.Multiplication());  
            Console.WriteLine("Division : " + Singleton.Instance.Division());  
            Console.WriteLine("\n----------------------\n");  
            Singleton.Instance.Num2 = 10;  
            Console.WriteLine("Addition : " + Singleton.Instance.Addition());  
            Console.WriteLine("Subtraction : " + Singleton.Instance.Subtraction());  
            Console.WriteLine("Multiplication : " + Singleton.Instance.Multiplication());  
            Console.WriteLine("Division : " + Singleton.Instance.Division());  
            Console.ReadLine();  
        }
    }
}
