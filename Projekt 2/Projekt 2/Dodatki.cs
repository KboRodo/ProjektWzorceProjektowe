using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{
    public abstract class Sklad:IBurger
    {
        IBurger _burger;
        public string _dodatki;
        public decimal _cena;

        public Sklad(IBurger burger)
        {
            _burger = burger;
        }
        public string zwrocNazwa()
        {
            return string.Format("{0},{1}", _burger.zwrocNazwa(), _dodatki);
        }
        public decimal zwrocCena()
        {
            return (_burger.zwrocCena() + _cena);
        }
    }
    #region Pieczywa
    // Pieczywo (Z sezamem - 2PLN, Z serem - 4PLN, Zwykla - Za darmo)
    public class Zwykle:Sklad
    {
        public Zwykle(IBurger burger) : base(burger)
        {
            _dodatki = "Białe pieczywo";
            _cena = 0;
        }
    }

    public class Sezam : Sklad
    {
        public Sezam(IBurger burger) : base(burger)
        {
            _dodatki = "Pieczywo z sezamem";
            _cena = 2;
        }
    }
    public class PieczywoSer : Sklad
    {
        public PieczywoSer(IBurger burger) : base(burger)
        {
            _dodatki = "Pieczywo z serem";
            _cena = 4;
        }
    }
    #endregion Pieczywa

    #region Mięsa
    //Mieso (Wołowina - 1 PLN, Kurczak - 0,5 PLN, Wege - 2PLN, Jagniecina - 4PLN)
    public class Wolowina : Sklad
    {
        public Wolowina(IBurger burger) : base(burger)
        {
            _dodatki = "Wołowina";
            _cena = 1;
        }
    }
    public class Kurczak : Sklad
    {
        public Kurczak(IBurger burger) : base(burger)
        {
            _dodatki = "Kurczak";
            _cena = 0.5M;                             
        }                                            
    }                                                
    public class Wege : Sklad                    
    {                                                
        public Wege(IBurger burger) : base(burger)       
        {
            _dodatki = "Wege";
            _cena = 2;
        }
    }
    public class Jagniecina : Sklad
    {
        public Jagniecina(IBurger burger) : base(burger)
        {
            _dodatki = "Jagniecina";
            _cena = 4;
        }
    }
    #endregion Mięsa

    #region Dodatki
    //Dodatki do burgera (Pomidor - 2PLN, Sałata - gratis, Cebula - 2PLN, Rukola - 6PLN)
    public class Pomidor : Sklad
    {
        public Pomidor(IBurger burger) : base(burger)
        {
            _dodatki = "Pomidor";
            _cena = 2;
        }
    }
    public class Salata : Sklad
    {
        public Salata(IBurger burger) : base(burger)
        {
            _dodatki = "Salata";
            _cena = 0;
        }
    }

    public class Cebula : Sklad
    {
        public Cebula(IBurger burger) : base(burger)
        {
            _dodatki = "Cebula";
            _cena = 2;
        }
    }
    public class Rukola : Sklad
    {
        public Rukola(IBurger burger) : base(burger)
        {
            _dodatki = "Rukola";
            _cena = 6;
        }
    }
    #endregion Dodatki

    #region Sosy
    //Sos Wyszystkie gratis (Sos BBQ ,Sos Czosnkowy , sos Teksański ,Ketchup )
    public class BBQ : Sklad
    {
        public BBQ(IBurger burger) : base(burger)
        {
            _dodatki = "BBQ";
            _cena = 0;
        }
    }
    public class Czosnek : Sklad
    {
        public Czosnek(IBurger burger) : base(burger)
        {
            _dodatki = "Czosnkowy";
            _cena = 0;
        }
    }
    public class Teksanski : Sklad
    {
        public Teksanski(IBurger burger) : base(burger)
        {
            _dodatki = "Teksański";
            _cena = 0;
        }
    }
public class Ketchup : Sklad
{
    public Ketchup(IBurger burger) : base(burger)
    {
        _dodatki = "Ketchup";
        _cena = 0;
    }
}

    #endregion Sosy
}
