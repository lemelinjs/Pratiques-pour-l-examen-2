using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclarer
            int[,] position;
            
            // Instancier avec des cases vides
            position = new int[5,5];
            for (int j = 0; j < position.GetLength(1); j++)
            {
                for (int i = 0; i < position.GetLength(0); i++)
                {
                    position[i, j] = (j + 1) * (i + 1);
                }
            }

            // Déclarer et instancier avec des cases vides
            int[,] tictactoe = new int[5, 5];

            //Déclarer, instancier et initialiser
            int[,] stationnement = new int[,] { {1,2},{3,4},{5,6} };

            //Initialiser avec des valeurs
            tictactoe[1, 1] = 32;

            //Manière d'accéder à toutes les données
            //For imbriqué
            for (int j = 0; j < stationnement.GetLength(1); j++)
            {
                for (int i = 0; i < stationnement.GetLength(0); i++)
                {
                    Console.WriteLine(i.ToString() + " - "+ j.ToString() + " " + stationnement[i, j]);
                }
            }

            //foreach de gauche à droite
            foreach (int nombre in position)
            {
                Console.WriteLine(nombre.ToString());
            }
            Console.ReadKey();
        }
    }
}
