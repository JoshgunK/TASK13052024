namespace Task2Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 50505050;
            int counter = 0;
            while (number > 0)
            {
                number /= 10;
                counter++;
            }
            Console.WriteLine($"Daxil etdiyiniz reqem {counter} mertebelidir ");

            Console.ReadLine();
        }
    }
}
