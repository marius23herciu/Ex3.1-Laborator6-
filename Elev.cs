using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3._1_Laborator6_
{
    class Elev
    {
        private string nume;
        private string prenume;
        private int[] listaNote;
        /// <summary>
        /// Introducere elev cu nume, prenume si note.
        /// </summary>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        /// <param name="note"></param>
        public Elev(string nume, string prenume, int[] note)
        {

            this.nume = nume;
            this.prenume = prenume;
            this.listaNote = note;
        }
        /// <summary>
        /// Calculeaza media pentru un elev.
        /// </summary>
        /// <returns></returns>
        public double GetMedie()
        {
            double medieCurenta = 0;
            for (int i = 0; i < listaNote.Length; i++)
            {
                medieCurenta += listaNote[i];
            }
            medieCurenta = medieCurenta / listaNote.Length;

            return medieCurenta;
        }
        /// <summary>
        /// Tipareste numele si prenumele.
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine($"{nume} {prenume}");
        }
    }
}
