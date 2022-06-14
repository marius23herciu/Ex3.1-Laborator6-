using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3._1_Laborator6_
{
    class Catalog
    {
        private string numeleClasei;
        private Elevi[] listaElevi;
        /// <summary>
        /// Seteaza numele clasei si introduce elevi.
        /// </summary>
        /// <param name="numeleClasei"></param>
        /// <param name="elev"></param>
        public Catalog(string numeleClasei, Elevi[] elev)
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
            foreach (Elevi elev in listaElevi)
            {
                elev.Tipareste();
            }
        }
        /// <summary>
        /// Returneaza un vector cu toate mediile elevilor.
        /// </summary>
        /// <returns></returns>
        public double[] GetMedii()
        {
            double[] medii = new double[listaElevi.Length];
            for (int i = 0; i < listaElevi.Length; i++)
            {
                medii[i] = listaElevi[i].GetMedie();
            }

            return medii;
        }
        /// <summary>
        /// Returneaza indexul din Catalog al elevului premiant.
        /// </summary>
        /// <returns></returns>
        public int GetPremiant()
        {
            double[] medii = GetMedii();
            int indexPremiant = 0;
            double medieMax = 0;
            for (int i = 0; i < medii.Length; i++)
            {
                if (medii[i] > medieMax)
                {
                    medieMax = medii[i];
                    indexPremiant = i;
                }
            }

            return indexPremiant;
        }
    }
}
