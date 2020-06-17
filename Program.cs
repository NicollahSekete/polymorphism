using System;

namespace POLYMORPHISM
{
    class UserInput
    {
        public void  ShowMeTheUserInput(int userData)
        {
            Console.WriteLine($"the user inputted{userData}");

        }
        public void  ShowMeTheUserInput(string userData)
        {
            Console.WriteLine($"the user inputted{userData}");
            
        }
        public void  ShowMeTheUserInput(double userData)
        {
            Console.WriteLine($"the user inputted {userData}");
            
        }
        
        public void Addition(bool numberOne, float numberTwo)
        {
         Console.WriteLine(Convert.ToDouble(numberOne) + Convert.ToDouble(numberTwo));
        }
        public void Addition(string numberOne, int numberTwo)
        {
         Console.WriteLine(Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo));
        }
        public void Addition(decimal numberOne, decimal numberTwo)
        {
         Console.WriteLine(Convert.ToSingle(numberOne) + Convert.ToSingle(numberTwo));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput newUser = new UserInput();
    
            newUser.Addition("10", 10);
            newUser.Addition(true, 6.2f);
            newUser.Addition(64.9m, 69.5m);
            //newUser.Addition(); // encapsulated method
            hidden example = new hidden();
            example.hiddenItems();
    }}
}