using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.BUSINESSLOGIC.Models
{
    public class ClienteEndereco
    {
        public decimal EnderecoId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public decimal ClienteId { get; set; }
    }
}
