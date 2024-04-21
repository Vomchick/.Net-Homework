namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                int j = i;
                while (j > 11)
                {
                    if (j % 12 == 10) counter++;
                    j /= 12;
                }
                if (counter == 2) Console.Write(i + " ");
                counter = 0;
            }
        }
    }
}
