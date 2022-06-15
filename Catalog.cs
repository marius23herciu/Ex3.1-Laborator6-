using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3._1_Laborator6_
{
    class Catalog
    {
        private string numeleClasei;
        private Elev[] listaElevi;
        /// <summary>
        /// Seteaza numele clasei si introduce elevi.
        /// </summary>
        /// <param name="numeleClasei"></param>
        /// <param name="elev"></param>
        public Catalog(string numeleClasei, Elev[] elev)
        {
            this.numeleClasei = numeleClasei;
            this.listaElevi = elev;
        }
        /// <summary>
        /// Tipareste fiecare elev dintr-o clasa Catalog.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine(numeleClasei);
            foreach (Elev elev in listaElevi)
            {
                elev.Tipareste();
            }
        }
        /// <summary>
        /// Returneaza obiectul Elev din Catalog cu media cea mai mare.
        /// </summary>
        /// <returns></returns>
        public Elev GetPremiantul()
        {
            Elev elevPremiant = listaElevi[0];
            double medieMax = 0;
            for (int i = 0; i < listaElevi.Length; i++)
            {
                double medieCurenta = listaElevi[i].GetMedie();
                if (medieCurenta > medieMax)
                {
                    medieMax = medieCurenta;
                    elevPremiant = listaElevi[i];
                }
            }
            return elevPremiant;
        }
    }
}
