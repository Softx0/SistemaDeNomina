//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMANOMINA
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISTRO_TRANSACCION_INGRESO
    {
        public int ID_TRANSACCION_INGRESO { get; set; }
        public int ID_EMPLEADO { get; set; }
        public string TIPO_INGRESO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public decimal MONTO { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}