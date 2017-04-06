using System;
using System.Diagnostics;

namespace Tableaux
{
    class Program
    {
        //Déclaration
        static int[] nombreImpairs;
        static string[] salutation;

        //Déclarer, Instancier et Initialiser avec les données
        static string[] jourSemaine = {"Lundi","Mardi" };

        //Déclarer et instancier avec un nombre de cases vides
        static bool[] reponse = new bool[12];

        static void Main(string[] args)
        {
            //Instancier et initialiser avec des données
            nombreImpairs = new int[]{1,3,5,7,9};

            //Instanciers avec des cases vides
            salutation = new string[10];
            
            // Initialisation
            salutation[0] = "Je me sens très bien!";

            reponse[0] = true;
           
            Console.WriteLine(jourSemaine[0] + " " + 
                nombreImpairs[0] + " " + 
                salutation[0] +" " + 
                reponse[0].ToString());
            Console.ReadKey();

            // Parcourrir un tableau méthode 1
            for (int i = 0; i < nombreImpairs.Length; i++)
            {
                Debug.WriteLine(nombreImpairs[i]);
            }

            // Deuxième méthode
            foreach (int nombre in nombreImpairs)
            {
                Debug.WriteLine(nombre);
            }
        }
    }
}