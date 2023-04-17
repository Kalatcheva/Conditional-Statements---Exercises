using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace metricConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            string enterUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();

            if (enterUnit == "m")
            {
                switch (exitUnit)
                {
                    case "cm":
                        num = num * 100;
                        break;
                    case "mm":
                        num = num * 1000;
                        break;
                }
            }
            else if(enterUnit == "cm")
            {
                switch (exitUnit)
                {
                    case "m":
                        num = num / 100;
                        break;
                    case "mm":
                        num = num * 10;
                        break;
                }
            }
            else if(enterUnit == "mm")
            {
                switch (exitUnit)
                {
                    case "cm":
                        num = num / 10;
                        break;
                    case "m":
                        num = num / 1000;
                        break;
                }
            }
            Console.WriteLine(num.ToString("f3"));
            

        }
    }
    }
