using System;

namespace Operators_Overloading_Extension_Method_HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Camp camp1 = new Camp(5, 1, 1);
            Camp camp2 = new Camp(10, 1, 1);
            Console.WriteLine(camp2 > camp1);
            bool x = camp2 > camp1 ? true : false;
            Console.WriteLine(x);

            Camp camp3 = camp1 + camp2;
            Console.WriteLine(camp3);

            Console.WriteLine("*************************************");
            Car c1 = new Car() { Color = "Red", Id = CreateRandomLong(),NumOfDoors =4 };
            Car c2 = new Car() { Color = "Blue", Id = CreateRandomLong(), NumOfDoors = 2 };
            Car c3 = new Car() { Color = "White", Id = CreateRandomLong(), NumOfDoors = 4 };
            
            Car[] c4 = { c1, c2, c3 };



            Car[] c5 = c4.PrintCarList();
            


        }

      
        
       


        public static int CreateRandomLong()
        {
            Random r = new Random();
            return r.Next();
        }
    
    }

}
