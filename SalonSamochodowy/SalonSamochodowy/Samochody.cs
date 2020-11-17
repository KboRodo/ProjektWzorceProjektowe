using System;
using System.Collections.Generic;
using System.Text;

namespace SalonSamochodowy
{
    enum TYP { SUV, VAN, SEDAN, KOMBI }//typy samochodow 
    abstract class Samochod
    {
        public abstract Parametry stworzSamochod();//abstract samochod k

        public static Samochod wybierzSamochod(TYP typSamochodu)
        {
            switch (typSamochodu)
            {
                case TYP.KOMBI:
                    return new SamochodKombi();


                case TYP.VAN:
                    return new SamochodVan();

                case TYP.SEDAN:
                    return new SamochodSedan();


                case TYP.SUV:
                    return new SamochodSuv();

                default:
                    throw new System.ArgumentException("Nie ma takiego rodzaju samochodu");

            }
        }
    }
    //TWORZENIE ROZNYCH SAMOCHODOW 
    class SamochodKombi : Samochod
    {
        public override Parametry stworzSamochod()
        {
            return new ParametryKombi();
        }
    }
    class SamochodVan : Samochod
    {
        public override Parametry stworzSamochod()
        {
            return new ParametryVan();
        }
    }
    class SamochodSuv : Samochod
    {
        public override Parametry stworzSamochod()
        {
            return new ParametrySuv();
        }
    }
    class SamochodSedan : Samochod
    {
        public override Parametry stworzSamochod()
        {
            return new ParametrySedan();
        }
    }
}