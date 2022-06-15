using System;

namespace zespolowy
{
    interface IOperacje
    {
        float Wykonaj(float liczba1, float liczba2);
        
    }
    //class Dodawanie 
    ////{

    ////}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WypiszImie());
        }

        static string WypiszImie()
        {
            return "Filip";
        }
       
    }
}
