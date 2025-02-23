using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Usuario
    {
        [Key]  // Indica que es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incremento
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(100)] // Limitamos la longitud
        public string NombreUsuario { get; set; }

        [Required]
        [EmailAddress] // Validación de correo electrónico
        [StringLength(100)] // Limitamos la longitud
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(200)] // Aseguramos una longitud apropiada para la contraseña
        public string Clave { get; set; }

        [ForeignKey("Rol")]  // Relación con la tabla 'Rol'
        public int RolID { get; set; }

        // Constructores
        public Usuario(string correo, string clave)
        {
            CorreoElectronico = correo;
            Clave = clave;
        }

        public Usuario(string nombre, string correo, string clave, int rol)
        {
            NombreUsuario = nombre;
            CorreoElectronico = correo;
            Clave = clave;
            RolID = rol;
        }

        public Usuario()
        {
        }
    }
}
