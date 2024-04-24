namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int bigger = Math.Max(a, b);
            int smaller = Math.Min(a, b);
            int counter = 0;
            for (int i = smaller; i <= bigger; i++)
            {
                int j = i;
                while (Math.Abs(j) > 11)
                {
                    if (Math.Abs(j % 12) == 10)
                    {
                        counter++;
                    }
                    j /= 12;
                }
                if (counter == 2)
                {
                    Console.Write(i + " ");
                }
                counter = 0;
            }
        }
    }
}
