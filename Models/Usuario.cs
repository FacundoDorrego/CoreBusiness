using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Usuario
    {
        [Key]  // Indica que es la clave primaria
        public string UsuarioID { get; set; } // Cambiado a string (VARCHAR(36))

        [Required]
        [StringLength(100)] // Limitamos la longitud
        public string NombreUsuario { get; set; }

        [ForeignKey("Rol")]  // Relación con la tabla 'Rol'
        public int RolID { get; set; }



        public Usuario(string nombre, int rol)
        {
            NombreUsuario = nombre;
            RolID = rol;
        }

        public Usuario()
        {
        }
    }
}
