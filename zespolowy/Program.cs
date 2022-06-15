using System;

namespace zespolowy
{
    interface IOperacje
    {
        float Wykonaj(float liczba1, float liczba2);
        
    }
    class Dodawanie : IOperacje
    {
        public float Wykonaj(float liczba1, float liczba2)
        {
            return liczba1 + liczba2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dodawanie d = new Dodawanie();
            Console.WriteLine(d.Wykonaj(10, 2));
        }

        static string WypiszImie()
        {
            return "Filip";
        }
       
    }
}
