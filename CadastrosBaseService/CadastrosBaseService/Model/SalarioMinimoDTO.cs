using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace CadastrosBaseService.Model
{
    [DataContract]
    public class SalarioMinimoDTO
    {
        #region Propriedades
        [DataMember]
        public Int32 id {get; set;}
        public DateTime vigencia {get; set;}
        public Decimal valor_mensal {get; set;}
        public Decimal valor_diario {get; set;}
        public Decimal valor_hora {get; set;}
        public string norma_legal {get; set;}
        public DateTime dou {get; set;}
        #endregion
    }
}