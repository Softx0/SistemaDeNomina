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
    
    public partial class MOVIMIENTO_EMPLEADO
    {
        public int ID_MOVIMIENTO { get; set; }
        public int ID_EMPLEADO { get; set; }
        public decimal MONTO_PAGAR { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
    }
}
