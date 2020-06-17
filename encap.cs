using System;

namespace POLYMORPHISM
{
    class hidden
    {
        private string numberOne;
        private bool numberTwo;

        public void hiddenItems()
        {
            numberOne = "12";
            numberTwo = true;

            Console.WriteLine(Convert.ToInt32(numberOne) + Convert.ToDouble(numberTwo));
        }
    }
}