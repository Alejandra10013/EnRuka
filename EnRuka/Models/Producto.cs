//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnRuka.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int Id { get; set; }
        public string Insumo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Temporada { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> Cantidad { get; set; }
    }
}