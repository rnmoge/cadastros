using System;
using System.Text;
using System.Collections.Generic;


namespace CadastrosBaseService.Model {
    
    public class AlmoxarifadoDTO {
        public AlmoxarifadoDTO() { }
        public int Id { get; set; }
        public EmpresaDTO Empresa { get; set; }
        public string Nome { get; set; }
    }
}
