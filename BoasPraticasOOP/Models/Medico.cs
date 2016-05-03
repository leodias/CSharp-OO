using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasPraticasOOP.Models
{
    public class Medico
    {
        public int IDMedico { get; set; }
        public int IDCidade { get; set; }
        public int IDEspecialidade { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public byte AtendePorConvenio { get; set; }
        public byte TemClinica { get; set; }
        public string WebsiteBlog { get; set; }
    }
}
