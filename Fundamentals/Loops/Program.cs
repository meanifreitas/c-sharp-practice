internal class Program
{
    static void main(string[] args)
    {
        int i;
        
        Console.WriteLine("Incrementing:");

        for (i = 0; i < 10; i++)
        {
            if (i == 7)
            {
                break;
            }
            Console.WriteLine("i: " + i);
        }

        Console.WriteLine("Decrementing:");

        for (i = 10; i > 0; i--)
        {
            if (i == 5)
            {
                continue;
            }
            Console.WriteLine("i: " + i);
        }
    }
}