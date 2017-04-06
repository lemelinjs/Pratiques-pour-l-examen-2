using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_d_objets
{
    class Program
    {
        static void Main(string[] args)
        {
            Objet[] tab1 = new Objet[5];

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = new Objet();
                tab1[i].Initialiser();
            }

            for (int k = 0; k < tab1.Length; k++)
            {
                //Afficher le tableau 2D appelé dimension2D qui est associé à l'espace k du tableau tab1
                Console.WriteLine();
                Console.WriteLine("Affichage du Tableau {0}", k+1);
                for (int j = 0; j < tab1[k].dimension2D.GetLength(1); j++)
                {
                    for (int i = 0; i < tab1[k].dimension2D.GetLength(0); i++)
                    {
                        Console.Write("{0,-10} ", tab1[4].dimension2D[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
