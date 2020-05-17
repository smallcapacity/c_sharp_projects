using System;

namespace SimpleCalculator
{
    public class Person
    {
        private int _age = 25;
        
        public int getAge()
        {
            return _age;
        }

        public void setAge(int newAge)
        {
            _age = newAge;
        }

        public static void greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}