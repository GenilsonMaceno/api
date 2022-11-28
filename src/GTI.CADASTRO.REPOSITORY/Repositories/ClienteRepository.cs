using GTI.CADASTRO.BUSINESSLOGIC.Models;
using GTI.CADASTRO.REPOSITORY.Context;
using GTI.CADASTRO.REPOSITORY.Models.Tables;
using GTI.CADASTRO.REPOSITORY.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<decimal> IncluirCliente(Cliente cliente)
        {
            try
            {

                var tbCliente = new TB_CLIENTES()
                {
                    CPF = cliente.CPF,
                    DATA_EXPEDICAO = cliente.DataExpedicao,
                    DATA_NASCIMENTO = cliente.DataNascimento,
                    ESTADO_CIVIL = cliente.EstadoCivil,
                    NOME = cliente.Nome,
                    ORGAO_EXPEDICAO = cliente.OrgaoExpedicao,
                    RG = cliente.RG,
                    SEXO = cliente.Sexo,
                    UF_EXPEDICAO = cliente.UF
                };


                var entity = _context.TB_CLIENTES.Add(tbCliente);
                var result =  await _context.SaveChangesAsync();

                if (result > 0)
                {
                    var tbClienteEndereco = new TB_CLIENTES_ENDERECOS()
                    {
                        CEP = cliente.Endereco.CEP,
                        BAIRRO = cliente.Endereco.Bairro,
                        CIDADE = cliente.Endereco.Cidade,
                        COMPLEMENTO = cliente.Endereco.Complemento,
                        LOGRADOURO = cliente.Endereco.Logradouro,
                        NUMERO = cliente.Endereco.Numero,
                        UF = cliente.Endereco.UF,
                        CLIENTE_ID = entity.CLIENTE_ID
                    };

                    _context.TB_CLIENTES_ENDERECOS.Add(tbClienteEndereco);
                    result = await _context.SaveChangesAsync();
                }

                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<decimal> IncluirClienteEndereco(ClienteEndereco clienteEndereco)
        {
            try
            {
                var tbClienteEndereco = new TB_CLIENTES_ENDERECOS()
                {
                    CEP = clienteEndereco.CEP,
                    BAIRRO = clienteEndereco.Bairro,
                    CIDADE = clienteEndereco.Cidade,
                    COMPLEMENTO = clienteEndereco.Complemento,
                    LOGRADOURO = clienteEndereco.Logradouro,
                    NUMERO = clienteEndereco.Numero,
                    UF = clienteEndereco.UF,
                    CLIENTE_ID = clienteEndereco.ClienteId
                };

                _context.TB_CLIENTES_ENDERECOS.Add(tbClienteEndereco);
                var ret = await _context.SaveChangesAsync();

                return ret;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
