using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace bonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int point = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if(point <= 100)
            {
                bonusPoints = 5;
            }
            else if(point > 100 & point <= 1000)
            {
                bonusPoints = point * 0.2;
            }
            else if(point > 1000)
            {
                bonusPoints = point * 0.1;
            }
            if(point % 2 == 0)
            {
                bonusPoints++;
            }
            else if(point % 5 == 0)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + point);

            

        }
    }
    }
