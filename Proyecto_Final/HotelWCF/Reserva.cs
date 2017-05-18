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
    
    public partial class Reserva
    {
        public Reserva()
        {
            this.Documento = new HashSet<Documento>();
        }
    
        public short id_Reserva { get; set; }
        public int id_Cliente { get; set; }
        public short id_Habitacion { get; set; }
        public byte id_Estado_Reserva { get; set; }
        public Nullable<short> id_Consumo { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_Salida { get; set; }
        public System.DateTime Fecha_Inicio_Reserva { get; set; }
        public System.DateTime Fecha_Fin_Reserva { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Consumo Consumo { get; set; }
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual Habitacion Habitacion { get; set; }
    }
}
