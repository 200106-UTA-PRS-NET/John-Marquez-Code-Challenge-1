using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class LibraryPal
    {
        public string Lower(string pal)
        {
            pal = pal.ToLower();
            return pal;
        }

        public string charRemoval(string pal)
        {
            pal = pal.Replace(" ", String.Empty);
            pal = pal.Replace(".", String.Empty);
            pal = pal.Replace(",", String.Empty);
            return pal;
        }
        public bool Palindrone(string pal)
        {
            int length = pal.Length;
            int j = pal.Length - 1;
            char[] arr;
            arr = pal.ToCharArray();
            bool check = true;

            for (int i = 0; i < length-1; i++)
            {
                if (arr[i] != arr[j])
                {
                    Console.WriteLine("Not a Palandrone");
                    check = false;
                    break;
                }
                j--;
            }

            Console.WriteLine("Correct! That is a Palindrone");
            return check;
        }


    }
}
