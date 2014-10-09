using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Vous avez oublié d'entrer votre nom")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Vous avez oublié d'entrer votre mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vous avez oublié d'entrer votre téléphone")]
        public string Telephone { get; set; }
        public bool? presence { get; set; }
    }
}