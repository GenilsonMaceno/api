using GTI.CADASTRO.BUSINESSLOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.API.Services.Interface
{
    public interface IClienteService
    {
        Task<Cliente> IncluirCliente(Cliente input);
    }
}
