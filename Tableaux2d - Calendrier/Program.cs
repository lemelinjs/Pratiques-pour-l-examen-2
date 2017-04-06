using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux2d___Calendrier
{
    /// <summary>
    /// Classe pour un calendrier du mois de février
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration, instantiation et initialisation du tableau de l'entete
            string[] entete = new string[] { "Dim", "Lun","Mar","Mer","Jeu", "Ven", "Sam"};

            //Déclaration instantiation avec des cases vides du tableau jours
            int[,] jours = new int[7,5];
            // Jour de départ
            int noJour = 1;

            //Écrire l'entete 
            foreach (string s in entete)
            {
                Console.Write("{0,4}", s);
            }
            
            Console.WriteLine();

            //Écrire les jours
            for (int j = 0; j < jours.GetLength(1); j++)
            {
                for (int i = 0; i < jours.GetLength(0); i++)
                {
                    if (j == 0 && i < 2)
                    {
                        if (i==0)
                        {
                            jours[i, j] = 30;
                        }
                        else 
                        {
                            jours[i, j] = 31;
                        }
                    }
                    else if (j==4 && i > 1)
                    {
                        for (int k = 0; k < jours.GetLength(0); k++)
                        {
                            jours[k, j] = k-1;
                        }
                    }
                    else
                    {
                        jours[i, j] = noJour;
                        noJour++;
                    }
                    
                    Console.Write("{0,4}",jours[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
