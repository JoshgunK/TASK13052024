int nomre = 5;

if (nomre == 0 || nomre == 1) ;
else
{
    for (int i = 2; i <= nomre / 2; i++)
    {
        if (nomre % i == 0)
        {
            Console.WriteLine($"{nomre} - Murekkeb ededdir");
            return;
        }

    }
    Console.WriteLine($"{nomre} - Sade ededdir");
}