using GTI.CADASTRO.API.Services.Interface;
using GTI.CADASTRO.BUSINESSLOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace GTI.CADASTRO.API.Controllers
{
    [RoutePrefix("/api/cadastro")]
    public class CadastroController : ApiController
    {
        private readonly IClienteService _clienteService;
        private CadastroOutput _Output;

        public CadastroController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: Cadastro
        [HttpPost]
        [Route("Cadastrar/cliente")]
        public async Task<HttpResponseMessage> Cadastrar(Cliente input)
        {

            try
            {
                _Output.Cliente = await _clienteService.IncluirCliente(input);
                _Output.Status = "Sucesso";
                _Output.MensagemCodigo = "Cliente cadastrado com sucesso";

                return Request.CreateResponse(HttpStatusCode.OK, _Output);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}