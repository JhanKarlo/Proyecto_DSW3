//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consumo
    {
        public short id_Consumo { get; set; }
        public byte id_Estado_Consumo { get; set; }
        public short id_Producto { get; set; }
        public System.DateTime Fecha { get; set; }
        public short cantidad { get; set; }
        public short id_Reserva { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Reserva Reserva { get; set; }
    }
}
