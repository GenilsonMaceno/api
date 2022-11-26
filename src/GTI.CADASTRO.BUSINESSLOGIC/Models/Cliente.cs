using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.BUSINESSLOGIC.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.Enderecos = new List<ClienteEndereco>();
        }

        public decimal ClienteId { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public DateTime DataExpedicao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UF { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string OrgaoExpedicao { get; set; }

        public ClienteEndereco Endereco { get; set; }
        public List<ClienteEndereco> Enderecos { get; set; }
    }
}
