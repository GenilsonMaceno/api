using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Models.Tables
{
    public class TB_ENDERECOS
    {
        public decimal ENDERECO_ID { get; set; }
        public decimal CEP { get; set; }
        public decimal LOGRADOURO { get; set; }
        public decimal NUMERO { get; set; }
        public decimal COMPLEMENTO { get; set; }
        public decimal BAIRRO { get; set; }
        public decimal CIDADE { get; set; }
        public decimal UF { get; set; }
    }
}
