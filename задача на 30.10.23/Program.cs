using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_на_30._10._23
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aaabbb";  //Console.ReadLine();
            int dlina = 2; //Convert.ToInt32(Console.ReadLine());
            string soglasnie = "aeiou";
            // a,e,i,o,u

            int goodtext = 0;
            while (dlina < text.Length)
            {
                string text2 = text.Substring(0, dlina); //aa
                int countglasn = 0;
                for (int i = 0; i < text2.Length; i++) //
                {
                    if (soglasnie.Contains(text2[i]))
                    {
                        countglasn++;
                    }
                }
                if (countglasn == dlina)
                {
                    text.Substring(dlina);
                }
                else if (countglasn < dlina)
                {

                    text.Substring(dlina);
                }


            }


            Console.WriteLine(text.Substring(dlina));
            Console.ReadLine();

        }
    }
}
