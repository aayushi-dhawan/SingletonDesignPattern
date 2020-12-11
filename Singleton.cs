using System;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton instance = null;
        private Singleton()
        {            

        }
        
        public static Singleton Instance 
        {
            get
            {
                if(instance != null)
                {
                    Console.WriteLine("Object already exist");
                    return instance;                
                }
                else
                {
                    Console.WriteLine("Object Created");
                    instance = new Singleton();
                    return instance;
                }
            }

        }

        public double Num1 { get; set; }  
        public double Num2 { get; set; }  
        
        public double Addition()  
        {  
            return Num1 + Num2;  
        }  
        public double Subtraction()  
        {  
            return Num1 - Num2;  
        }  
        public double Multiplication()  
        {  
            return Num1 * Num2;  
        }  
        public double Division()  
        {  
            return Num1 / Num2;  
        }   
    }
}