using System;
using System.Collections.Generic;
using System.Text;

namespace SalonSamochodowy      //fabryka
{
    abstract class Parametry
    {
        public abstract string zwroc();
    }
    class ParametryKombi : Parametry
    {
        public override string zwroc()
        {
            return "Kombi";
        }
    }

    class ParametrySedan : Parametry
    {
        public override string zwroc()
        {
            return "Papamobil";
        }
    }

    class ParametryVan : Parametry
    {
        public override string zwroc()
        {
            return "Van";
        }
    }

    class ParametrySuv : Parametry
    {
        public override string zwroc()
        {
            return "Suv";
        }
    }
}
