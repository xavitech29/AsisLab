//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Modelo.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medico()
        {
            this.muestra = new HashSet<muestra>();
        }
    
        public int id_medico { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string especialidad { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<muestra> muestra { get; set; }
    }
}