using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentasID { get; set; }

        public decimal Monto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }

        public int EmpresaID { get; set; }
        public string UsuarioID { get; set; }
        public int ProductoID { get; set; }
        public int CategoriaID { get; set; }

        [ForeignKey(nameof(EmpresaID))]
        public Empresa Empresa { get; set; }

        [ForeignKey(nameof(UsuarioID))]
        public Usuario Usuario { get; set; }

        [ForeignKey(nameof(ProductoID))]
        public Producto Producto { get; set; }

        [ForeignKey(nameof(CategoriaID))]
        public Categoria Categoria { get; set; }
    }
}
