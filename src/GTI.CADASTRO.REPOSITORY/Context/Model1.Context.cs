﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GTI_DATA_SERVEREntities : DbContext
    {
        public GTI_DATA_SERVEREntities()
            : base("name=GTI_DATA_SERVEREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_CLIENTES> TB_CLIENTES { get; set; }
        public virtual DbSet<TB_CLIENTES_ENDERECOS> TB_CLIENTES_ENDERECOS { get; set; }
    }
}
