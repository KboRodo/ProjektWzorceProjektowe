using System;
using System.Collections.Generic;
using System.Text;

//!!!!!
//ZMIANA KONCEPCJI DO DO WYSWIETLANIA 
//PRZEROBIĆ OVERRIDY PARAMATROW ZEBY BYŁY TAK JAK W PRZYPDAKU KOMBI- 2 METODY STRING I DECIMAL
namespace SalonSamochodowy      //fabryka
{
    abstract class Parametry
    {
        public abstract string zwrocNazwa();
        public abstract decimal zwrocCena();  
    }
    class ParametryKombi : Parametry
    {
        public override string zwrocNazwa()
        {
            return "Kombi";
        }
        public override decimal zwrocCena()
        {
            return (90000);
        }
    }

    class ParametrySedan : Parametry
    {
        public override string zwrocNazwa()
        {
            return new string[] { "Papamobil", "213700" };
        }
    }

    class ParametryVan : Parametry
    {
        public override string[] zwroc()
        {
            return new string[] { "Van", "70000" };
        }
    }

    class ParametrySuv : Parametry
    {
        public override string[] zwroc()
        {
            return new string[] { "Suv", "150000" };
        }
    }
}
