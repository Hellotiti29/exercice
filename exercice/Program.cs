using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration
            float prixHT, TVA, TTC;

            //Saisie d'un prix HT
            Console.WriteLine("Entrez le prix HT :");
            prixHT = float.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la TVA : ");
            TVA = float.Parse(Console.ReadLine());

            // Calcul de TTC
            TTC = prixHT + TVA;

            // Affichage de la TVA
            Console.WriteLine("Le prix du TTC est " + TTC);
            Console.ReadLine();
        }
    }
}
