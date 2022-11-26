using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Models.Tables
{
    public class TB_CLIENTES_ENDERECOS
    {
        public decimal ENDERECO_ID { get; set; }
        public string CEP { get; set; }
        public string LOGRADOURO { get; set; }
        public string NUMERO { get; set; }
        public string COMPLEMENTO { get; set; }
        public string BAIRRO { get; set; }
        public string CIDADE { get; set; }
        public string UF { get; set; }
        public decimal CLIENTE_ID { get; set; }

        public virtual TB_CLIENTES TB_CLIENTES { get; set; }
    }
}
