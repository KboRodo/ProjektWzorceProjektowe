using System;
using System.Collections.Generic;
using System.Text;

namespace SalonSamochodowy      //fabryka
{
    public interface Parametry
    {
        public abstract string zwrocNazwa();
        public abstract decimal zwrocCena();  
    }
    class ParametryKombi : Parametry
    {
        public string zwrocNazwa()
        {
            return "Kombi";
        }
        public decimal zwrocCena()
        {
            return (90000);
        }
    }

    class ParametrySedan : Parametry
    {
        public string zwrocNazwa()
        {
            return "Papamobil";
        }
        public decimal zwrocCena()
        {
            return (21370);
        }
    }

    class ParametryVan : Parametry
    {
        public string zwrocNazwa()
        {
            return "Van";
        }
        public decimal zwrocCena()
        {
            return (80000);
        }
    }

    class ParametrySuv : Parametry
    {
        public string zwrocNazwa()
        {
            return "Suv";
        }
        public decimal zwrocCena()
        {
            return (80000);
        }
    }
}