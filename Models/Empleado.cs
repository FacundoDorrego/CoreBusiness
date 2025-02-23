using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Empleado
    {
        [Key]  // Indica que es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoID { get; set; }
        public Usuario Usuario { get; set; }
        public Empresa Empresa { get; set; }


        public Empleado(Usuario auxUsu, Empresa auxEmpre)
        {
            Usuario = auxUsu;
            Empresa = auxEmpre;
        }

        public Empleado()
        {

        }


    }
}
