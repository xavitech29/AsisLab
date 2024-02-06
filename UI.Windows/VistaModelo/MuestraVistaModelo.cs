using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.VistaModelo
{
    public class MuestraVistaModelo
    {
        public int Id_muestra { get; set; }
        public Nullable<int> Id_paciente { get; set; }
        public Nullable<int> Id_medico { get; set; }
        public Nullable<int> Id_tipo_prueba { get; set; }
        public Nullable<int> Id_departamento { get; set; }
        public Nullable<System.DateTime> Fecha_recepcion { get; set; }
        public Nullable<bool> Estado { get; set; }
    }
}
