using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Veuillez renseigner votre nom")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner votre mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner votre Téléphone")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Veuillez nous informer votre présence")]
        public bool? presence { get; set; }
    }
}