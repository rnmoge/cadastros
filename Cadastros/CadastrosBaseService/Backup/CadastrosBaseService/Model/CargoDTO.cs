using System;
using System.Text;
using System.Collections.Generic;


namespace CadastrosBaseService.Model {
    
    public class CargoDTO {
        public CargoDTO() { }
        public int Id { get; set; }
        public EmpresaDTO Empresa { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public System.Nullable<decimal> Salario { get; set; }
        public string Cbo1994 { get; set; }
        public string Cbo2002 { get; set; }
    }
}
