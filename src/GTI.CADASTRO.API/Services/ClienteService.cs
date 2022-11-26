using GTI.CADASTRO.API.Services.Interface;
using GTI.CADASTRO.BUSINESSLOGIC.Models;
using GTI.CADASTRO.REPOSITORY.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GTI.CADASTRO.API.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteReposytory;

        public ClienteService(IClienteRepository clienteReposytory)
        {
            _clienteReposytory = clienteReposytory;
        }

        public async Task<Cliente> IncluirCliente(Cliente input)
        {
            try
            {
                var cliente = new Cliente();

                var retorno = await _clienteReposytory.IncluirCliente(input);

                if (retorno != 0)
                {
                    cliente.Nome = input.Nome;
                    return cliente;
                }

                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}