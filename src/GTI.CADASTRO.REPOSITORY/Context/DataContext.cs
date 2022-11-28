using GTI.CADASTRO.REPOSITORY.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GTI.CADASTRO.REPOSITORY.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=GTI_DATA_SERVEREntities")
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
