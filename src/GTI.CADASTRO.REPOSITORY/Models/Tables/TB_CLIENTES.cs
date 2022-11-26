using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Models.Tables
{
    public class TB_CLIENTES
    {
        public decimal CLIENTE_ID { get; set; }
        public decimal CPF { get; set; }
        public decimal NOME { get; set; }
        public decimal RG { get; set; }
        public decimal DATA_EXPEDICAO { get; set; }
        public decimal UF { get; set; }
        public decimal SEXO { get; set; }
        public decimal ESTADO_CIVIL { get; set; }
    }
}
