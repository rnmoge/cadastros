﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CadastrosBaseService.Model
{
    [DataContract]
    public class AtividadeForCliDTO
    {
        #region Propriedades
        [DataMember]
        public int? id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        #endregion
    }
}