using Lodziarnia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.ViewModel
{
    public class GodzinyView
    {
        public GodzinyView()
        {

        }
        public GodzinyView(IGodzinyPracy godziny)
        {
            Godziny = godziny;
            var g = godziny.GetAll().ToArray();
            for (int i = 0; i < 7; i++)
            {
                GodzinaStart[i] = g[i].GodzinaStart;
                MinutaStart[i] = g[i].MinutaStart;
                GodzinaEnd[i] = g[i].GodzinaEnd;
                MinutaEnd[i] = g[i].MinutaEnd;
            }

        }

        public IGodzinyPracy? Godziny { get; }
        [RegularExpression(@"^[0-1]\d|2[0-4]$")]
        public int[]? GodzinaStart = new int[7];
        public int[]? MinutaStart = new int[7];
        public int[]? GodzinaEnd = new int[7];
        public int[]? MinutaEnd = new int[7];

        [Display(Name = "Godzina Otwartcia")]
        [RegularExpression(@"(^[0-1''-'\s]{0,1}[0-9''-'\s]{1}$)|(^[2''-'\s]{1}[0-3''-'\s]{1}$)", ErrorMessage = "Wartości od 0 do 23")]
        public int GodzinaStart0 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        [RegularExpression(@"^[0-5''-'\s]{0,1}[0-9]{1}$", ErrorMessage = "Wartości od 0 do 59")]

        public int MinutaStart0 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd0 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd0 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart1 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart1 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd1 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd1 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart2 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart2 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd2 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd2 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart3 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart3 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd3 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd3 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart4 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart4 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd4 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd4 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart5 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart5 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd5 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd5 { get; set; }

        [Display(Name = "Godzina Otwartcia")]
        public int GodzinaStart6 { get; set; }
        [Display(Name = "Minuta Otwarcia")]
        public int MinutaStart6 { get; set; }
        [Display(Name = "Godzina Zamknięcia")]
        public int GodzinaEnd6 { get; set; }
        [Display(Name = "Minuta Zamknięcia")]
        public int MinutaEnd6 { get; set; }

    }
}
