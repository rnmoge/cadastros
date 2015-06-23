using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CadastrosBaseService.Model
{
    [DataContract]
    public class OperadoraPlanoSaudeDTO
    {
        #region Propriedades
        [DataMember]
        public int? id { get; set; }
        [DataMember]
        public int? IdContabilConta { get; set; }
        [DataMember]
        public string RegistroAns { get; set; }
        [DataMember]
        public string nome { get; set; }
        #endregion
    }
}