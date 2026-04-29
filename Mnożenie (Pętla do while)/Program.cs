class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        
        do
        {
            int j = 1;
            do
            {
                
                Console.Write($"{j * i}\t");
                j++;

            } while (j <= 10);
            i++;
            Console.WriteLine();

        } while (i <= 10);
        Console.WriteLine();






    }
}