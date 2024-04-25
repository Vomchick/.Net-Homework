namespace Task1._3
{
    internal class Program
    {
        static int[] SetCreation(int[] arr)
        {
            int count = 0;
            bool repeat = false;
            int[] set = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        repeat = true;
                        break;
                    }
                }
                if (!repeat)
                {
                    set[count++] = arr[i];
                }
                else 
                { 
                    repeat = false; 
                }
            }
            Array.Resize(ref set, count);
            
            return set;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of elemets");
            var arr = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine($"Input {arr.Length} elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            var set = SetCreation(arr);
            foreach (int i in set) 
            { 
                Console.Write(i + " "); 
            }
        }
    }
}
