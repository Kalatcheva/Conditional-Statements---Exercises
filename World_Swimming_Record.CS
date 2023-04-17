using System;
using System.IO;
using System.Security.Cryptography;
using System.Transactions;

namespace worldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secsPerOneMeter = double.Parse(Console.ReadLine());

            double time = meters * secsPerOneMeter;
            double bonus = Math.Floor(meters / 15) * 12.5;
            double finalTime = time + bonus;

            if(worldRecord > finalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
                //double secsBehind = worldRecord - finalTime;
                //Console.WriteLine($"No, he failed! he was {secsBehind} seconds slower.");
            }
            else
            {
                //Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime} seconds.");
                double secsBehind = (worldRecord - finalTime) * -1;
                Console.WriteLine($"No, he failed! He was {secsBehind:f2} seconds slower.");
            }
            

        }
    }
    }
