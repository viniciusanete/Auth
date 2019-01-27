using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNI.Leviter.Models.Usuario
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }
	    public string Login { get; set; }
	    public string Senha { get; set; }
    }
}