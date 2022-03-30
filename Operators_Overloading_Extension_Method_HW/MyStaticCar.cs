using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overloading_Extension_Method_HW
{
    public static class MyStaticCar
    {

        public static Car[] PrintCarList(this Car[] car)
        {
            return car;

        }
        public static string LastLowerCase(this string text)
        {
            string resText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1 || text[i + 1] == ' ')
                    resText += text[i].ToString().ToLower();
                else resText += text[i];
            }
            return resText;
        }

    }
}
