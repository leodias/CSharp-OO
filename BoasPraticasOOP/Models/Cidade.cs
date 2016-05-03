using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasPraticasOOP.Models
{
    public class Cidade
    {
        public int IDCidade { get; set; }

        //[Required(ErrorMessage = "O campo Nome é de preenchimento obrigatório.")]
        //[StringLength(100, ErrorMessage = "O campo Nome deve possuir no máximo 100 caracteres.")]
        public string Nome { get; set; }
    }
}
