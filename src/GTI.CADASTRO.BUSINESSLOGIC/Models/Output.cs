using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.BUSINESSLOGIC.Models
{
    public class Output
    {
        public Guid? IdTransacao { get; set; }

        /// <summary>
        /// Status do processamento retornado pelo endpoint
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Código do processamento retornado pelo endpoint, de acordo com o endpoint e regra em questão
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Mensagem do processamento retornado pelo endpoint, de acordo com o endpoint e regra em questão
        /// </summary>
        public string MensagemCodigo { get; set; }
    }
}
