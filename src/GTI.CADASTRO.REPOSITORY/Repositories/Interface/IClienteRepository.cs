using GTI.CADASTRO.BUSINESSLOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Repositories.Interface
{
    public interface IClienteRepository
    {
        Task<decimal> IncluirCliente(Cliente cliente);
        Task<decimal> IncluirClienteEndereco(ClienteEndereco clienteEndereco);
    }
}
