using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please type in a Palandrone");
            string pal = Console.ReadLine();

            LibraryPal lib = new LibraryPal();
            pal = lib.Lower(pal);
            pal = lib.charRemoval(pal);
            //pal = pal.ToLower();
            //pal = pal.Replace(" ", String.Empty);
            //pal = pal.Replace(".", String.Empty);
            //pal = pal.Replace(",", String.Empty);

            //Console.WriteLine(pal);
            //LibraryPal lib = new LibraryPal();
            lib.Palindrone(pal);
            
        }
    }
}
