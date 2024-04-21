namespace Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 9 digits");
            var digitInput = Console.ReadLine();
            int multiple = 10;
            int sum = 0;
            foreach (var digit in digitInput.ToCharArray())
            {
                sum += multiple-- * (int)Char.GetNumericValue(digit);
            }
            int checkDigit = 11 - sum % 11;
            if (checkDigit == 10) Console.WriteLine("Check digit id X");
            else Console.WriteLine($"Check digit is {checkDigit}");
        }
    }
}
