using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{
    class MalyBurger:IBurger
    {
        public string zwrocNazwa()
        {
            return "Mały burger";
        }
        public decimal zwrocCena()
        {
            return (10);
        }
    }

    class DuzyBurger : IBurger
    {
        public string zwrocNazwa()
        {
            return "Duży burger";
        }
        public decimal zwrocCena()
        {
            return (12);
        }
    }
}
