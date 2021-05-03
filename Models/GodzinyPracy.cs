using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.Models
{
    public class GodzinyPracy
    {
        [Required][Key]
        public Dzien DzienID { get; set; }
        [Required]
        [RegularExpression(@"^[0-1]\d|2[0-4]$")]
        public int GodzinaStart { get; set; }
        [Required]
        public int MinutaStart { get; set; }
        [Required]
        public int GodzinaEnd { get; set; }
        [Required]
        public int MinutaEnd { get; set; }
        public GodzinyPracy(Dzien day, string GodzinaMinutaStart, string GodzinaMinutaEnd)
        {
            DzienID = day; GodzinaStart = Convert.ToInt32(GodzinaMinutaStart.Split(":")[0]); MinutaStart = Convert.ToInt32(GodzinaMinutaStart.Split(":")[1]);
            GodzinaEnd = Convert.ToInt32(GodzinaMinutaEnd.Split(":")[0]); MinutaEnd = Convert.ToInt32(GodzinaMinutaEnd.Split(":")[1]);
        }
        public GodzinyPracy()
        {

        }
        public string StringHourStart()
        {
            return GodzinaStart + ":" + MinutaStart;
        }
        public string StringHourEnd()
        {
            return GodzinaEnd + ":" + MinutaEnd;
        }
    }
}
