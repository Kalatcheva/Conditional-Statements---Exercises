namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());
            int totalTime = firstSeconds + secondSeconds + thirdSeconds;
            int timeMinutes = totalTime / 60;
            int timeSeconds = totalTime % 60;

            if (timeSeconds < 10)
            {
                Console.WriteLine($"{timeMinutes}:0{timeSeconds}");
            }
            else
            {
                Console.WriteLine($"{timeMinutes}:{timeSeconds}");
            }
               
            }
        
