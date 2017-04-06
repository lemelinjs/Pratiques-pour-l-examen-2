using System;
using System.Diagnostics;

namespace EnumPratique01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Ennumerations cp1 = new Ennumerations();
            //J'asssige une valeur enum à l'objet cp1 
            //Je réfère à la class Enumerations et au type d'ennum ComptesResultats
            cp1.Resultats[1] = Ennumerations.ComptesResultats.Bas;
            Ennumerations jour = new Ennumerations();
            jour.Jour[2] = Ennumerations.JourDelaSemaine.Lundi;

            Console.WriteLine("Le compte de particule cp1 de {0} était {1} ", jour.Jour[2], cp1.Resultats[1]);
            Console.ReadKey();
        }
    }
}