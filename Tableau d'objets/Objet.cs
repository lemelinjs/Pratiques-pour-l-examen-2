using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_d_objets
{
    public class Objet
    {
        public Grosseur[,] dimension2D;
        private Random nombreAleatoire = new Random();

        public enum Grosseur
        {
            Petite,
            Moyenne,
            Grosse,
            TresGrosse
        }

        public void Initialiser()
        {
            dimension2D = new Grosseur[5, 2];

            for (int j = 0; j < dimension2D.GetLength(1); j++)
            {
                for (int i = 0; i < dimension2D.GetLength(0); i++)
                {
                    int nombre = nombreAleatoire.Next(1, 5);
                    switch (nombre)
                    {
                        case 1:
                            dimension2D[i, j] = Grosseur.Petite;
                            break;
                        case 2:
                            dimension2D[i, j] = Grosseur.Moyenne;
                            break;
                        case 3:
                            dimension2D[i, j] = Grosseur.Grosse;
                            break;
                        case 4:
                            dimension2D[i, j] = Grosseur.TresGrosse;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
