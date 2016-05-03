using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasPraticasOOP.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }

        //[Required(ErrorMessage = "O campo Nome é de preenchimento obrigatório.")]
        //[StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 80 caracteres.")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "O campo Login é de preenchimento obrigatório.")]
        //[StringLength(30, ErrorMessage = "O campo Login deve possuir no máximo 30 caracteres.")]
        public string Login { get; set; }

        //[Required(ErrorMessage = "O campo Senha é de preenchimento obrigatório.")]
        //[StringLength(100, ErrorMessage = "O campo Senha deve possuir no máximo 100 caracteres.")]
        public string Senha { get; set; }

        //[Required(ErrorMessage = "O campo E-mail é de preenchimento obrigatório.")]
        //[StringLength(100, ErrorMessage = "O campo E-mail deve possuir no máximo 100 caracteres.")]
        public string Email { get; set; }
    }
}
