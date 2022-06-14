using System;

namespace Ex3._1_Laborator6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elevi pe care doriti sa-l introduceti in catalog:");
            int n = int.Parse(Console.ReadLine());
            Elevi[] elev = new Elevi[n];
            CitesteElev(elev, n);

            Catalog unsprezeceD = new Catalog("XI-D", elev);

            unsprezeceD.Tipareste();

            int indexPremiant = unsprezeceD.GetPremiant();
            Console.WriteLine($"Elevul premiant este {elev[indexPremiant].GetNumePremiant()}");
        }
        public static Elevi[] CitesteElev(Elevi[] elev, int n)
        {
            Elevi[] elevi = new Elevi[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduceti numele:");
                string nume = Console.ReadLine();
                Console.WriteLine("Introduceti prenumele:");
                string prenume = Console.ReadLine();
                Console.WriteLine($"Introduceti numarul de note pentru elevul {nume} {prenume}:");
                int nrNote = int.Parse(Console.ReadLine());
                Console.WriteLine($"Introduceti {nrNote} note:");
                int[] note = new int[nrNote];
                for (int j = 0; j < nrNote; j++)
                {
                    note[j]= int.Parse(Console.ReadLine());
                }
                elev[i] = new Elevi(nume,prenume,note);
            }
            return elevi;
        }
    }
}
