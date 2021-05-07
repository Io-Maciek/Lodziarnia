using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public enum Dzien
    {
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota,
        Niedziela
    }
    public class ConvertDay
    {
        public static Dzien ReturnDay(int day)
        {
            day--;
            if (day == 0) return Dzien.Poniedziałek;
            else if (day == 1) return Dzien.Wtorek;
            else if (day == 2) return Dzien.Środa;
            else if (day == 3) return Dzien.Czwartek;
            else if (day == 4) return Dzien.Piątek;
            else if (day == 5) return Dzien.Sobota;
            else return Dzien.Niedziela;
        }
    }
}
