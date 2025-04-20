using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Empresa
    {
        [Key]  // Indica que es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioID { get; set; }
        public bool Activa { get; set; }
    }

}
