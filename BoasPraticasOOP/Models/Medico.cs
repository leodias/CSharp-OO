using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BoasPraticasOOP.Models
{
    public class Medico
    {
        public int IDMedico { get; set; }
        public int IDCidade { get; set; }
        public int IDEspecialidade { get; set; }

        [Required(ErrorMessage = "O campo CRM é de preenchimento obrigatório.")]
        [StringLength(30, ErrorMessage = "O campo CRM deve possuir no máximo 30 caracteres.")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "O campo Nome é de preenchimento obrigatório.")]
        [StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Endereço é de preenchimento obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Endereço deve possuir no máximo 100 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo Bairro é de preenchimento obrigatório.")]
        [StringLength(60, ErrorMessage = "O campo Bairro deve possuir no máximo 100 caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo E-mail é de preenchimento obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo E-mail deve possuir no máximo 100 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Atende Por Convênio é de seleção obrigatória.")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "O campo Tem Clínica é de seleção obrigatória.")]
        public bool TemClinica { get; set; }

        [StringLength(80, ErrorMessage = "O campo Nome deve possuir no máximo 100 caracteres.")]
        public string WebsiteBlog { get; set; }
    }
}
