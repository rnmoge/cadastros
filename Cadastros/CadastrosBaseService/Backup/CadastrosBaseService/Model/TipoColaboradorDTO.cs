using System;
using System.Text;
using System.Collections.Generic;


namespace CadastrosBaseService.Model {
    
    public class TipoColaboradorDTO {
        public TipoColaboradorDTO() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
