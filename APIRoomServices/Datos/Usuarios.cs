//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.CuentasBancarias = new HashSet<CuentasBancarias>();
            this.CuentasUsuarios = new HashSet<CuentasUsuarios>();
        }
    
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string genero { get; set; }
    
        public virtual Arrendadores Arrendadores { get; set; }
        public virtual Arrendatarios Arrendatarios { get; set; }
        public virtual ICollection<CuentasBancarias> CuentasBancarias { get; set; }
        public virtual ICollection<CuentasUsuarios> CuentasUsuarios { get; set; }
    }
}
