namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the String");
            string prevString = Console.ReadLine();
            string modifiedString= "";

            for (int i = 0; i < prevString.Length; i++)
            {
                char c = prevString[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    continue; // skip vowels
                }
                modifiedString += c;
                
            }

            Console.WriteLine("Original string: " + prevString);
            Console.WriteLine("Updated string: " + modifiedString);



        }
    }
}