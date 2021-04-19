using System;

namespace Tilfældigheder
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCIISubstitute ascii = new ASCIISubstitute();
            Console.WriteLine("Write a msg");
            string text = Console.ReadLine();
            Console.WriteLine("your text: " + text);
            for (int i = 0; i < 3; i++)
            {
                text = ascii.ASCIIEncrypt(text);
                Console.WriteLine($"encryption number {i+1}: {text} ");
            }
            Console.WriteLine("Encrypted text: " + text);
            Console.WriteLine("Decrypt your text: ");
            Console.ReadKey();
            Console.WriteLine("your encrypted text: " + text);
            for (int i = 0; i < 3; i++)
            {
                text = ascii.ASCIIDecrypt(text);
                Console.WriteLine($"Decryption number {i+1}: {text}");
            }
            Console.WriteLine("your decrypted text: " + text);
            Console.ReadKey();
        }
    }
}
