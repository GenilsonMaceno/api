//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GTI.CADASTRO.REPOSITORY.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CLIENTES_ENDERECOS
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