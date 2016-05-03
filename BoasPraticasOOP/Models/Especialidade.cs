using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoasPraticasOOP.Models
{
    public class Especialidade
    {
        public int IDEspecialidade { get; set; }

        [Required(ErrorMessage = "O campo Nome é de preenchimento obrigatório.")]
        [StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 100 caracteres.")]
        public int Nome { get; set; }
    }
}
