using System;
using System.Text;
using System.Collections.Generic;


namespace CadastrosBaseService.Model {
    
    public class TipoAdmissaoDTO {
        public TipoAdmissaoDTO() { }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
