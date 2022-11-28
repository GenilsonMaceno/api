using GTI.CADASTRO.REPOSITORY.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.REPOSITORY.Models.Tables
{
    public class TB_CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CLIENTES()
        {
            this.TB_CLIENTES_ENDERECOS = new HashSet<TB_CLIENTES_ENDERECOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CLIENTE_ID { get; set; }
        public string CPF { get; set; }
        public string NOME { get; set; }
        public string RG { get; set; }
        public Nullable<System.DateTime> DATA_EXPEDICAO { get; set; }
        public string ORGAO_EXPEDICAO { get; set; }
        public string UF_EXPEDICAO { get; set; }
        public System.DateTime DATA_NASCIMENTO { get; set; }
        public string SEXO { get; set; }
        public string ESTADO_CIVIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CLIENTES_ENDERECOS> TB_CLIENTES_ENDERECOS { get; set; }
    }
}
