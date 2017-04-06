using System;
using System.Collections.Generic;
using System.Text;

namespace EnumPratique01
{
    public class Ennumerations
    {
        private ComptesResultats[] resultats = new ComptesResultats[10];
        private JourDelaSemaine[] jour = new JourDelaSemaine[7];

        public ComptesResultats[] Resultats { get => resultats; set => resultats = value; }
        public JourDelaSemaine[] Jour { get => jour; set => jour = value; }

        public enum ComptesResultats
        {
            Bas,
            Moyen,
            Haut,
            HorsLimite
        }

        public enum JourDelaSemaine
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
    }
}
