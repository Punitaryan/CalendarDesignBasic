using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
   class Program
    {
        static void Main(string[] args)
        {
            // Input format - 02 April 2020
            // Output format - 2020-04-02
            String str;
            str = Console.ReadLine();
            String outputCalendarFormat = designCalen(str);
            Console.Out.WriteLine(outputCalendarFormat);
        }
        static String designCalen(String str)
        {
            Dictionary<string, int> monthDict = new Dictionary<string, int>();
            monthDict.Add("January", 01);
            monthDict.Add("February", 02);
            monthDict.Add("March", 03);
            monthDict.Add("April ", 04);
            monthDict.Add("May", 05);
            monthDict.Add("June", 06);
            
            int val = 0;
            String b = String.Empty;
            for (int i = 0; i < 2; i++)
            {
                if (Char.IsDigit(str[i]))
                    b += str[i];
            }
            if (b.Length > 0)
                val = int.Parse(b);

            string dateVal = val.ToString("#00");
            

            String month = String.Empty;
            String year = String.Empty;
            if (val <= 9)
            {
                for(int i=3; i<str.Length; i++)
                {
                    if (!Char.IsDigit(str[i]))
                        month += str[i];
                    else
                        year += str[i];
                }
                
            }
            if (val > 9 && val< 31)
            {
                for (int i = 4; i < str.Length; i++)
                {
                    if (!Char.IsDigit(str[i]))
                        month += str[i];
                    else
                        year += str[i];
                }
            }

            int monthVal = 0;
            String monthActual = String.Empty;

            bool monthSuccess = monthDict.TryGetValue(month, out monthVal);
            if (monthSuccess)
                monthActual =  monthVal.ToString("#00");

            String actualdate = year + "-" + monthActual + "-" + dateVal;
            Console.WriteLine(actualdate);

            return actualdate;
        }
    }
}
