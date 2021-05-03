using Lodziarnia.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lodziarnia.ViewModel
{
    public class LodyCreateView
    {
        public int SmakID { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(50, ErrorMessage = "Nazwa nie może przekraczać 50 znaków")]
        public string SmakNazwa { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany")]
        [MaxLength(500, ErrorMessage = "Nazwa nie może przekraczać 500 znaków")]
        public string SmakOpis { get; set; }

        [Required]
        [Display(Name = "Czy smak jest dostępny?")]
        public int SmakDostepny { get; set; }

        [Required]
        [Display(Name = "Czy zawiera alkohol?")]
        public int SmakAlkohol { get; set; }
        [Display(Name = "Dodaj zdjęcie")]
        public IFormFile SciezkaZdjecia { get; set; }
        [Display(Name = "Wybierz kategorię")]
        public KategoriaLoda kategoriaLoda { get; set; }
    }
}
