using Aplicacion.Servicios;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.VistaModelo;

namespace UI.Windows.ControladoresAplicacion
{
    public class MuestraControladorAplicacion
    {
        private MuestraService muestraServices;

        public MuestraControladorAplicacion()
        {
            muestraServices = new MuestraService();
        }

        public bool InsertarMuestra(MuestraVistaModelo nuevoMuestraVM)
        {
            muestra nuevoMuestraET = new muestra();
            try
            {

                nuevoMuestraET.id_paciente = nuevoMuestraVM.Id_paciente;
                nuevoMuestraET.id_medico = nuevoMuestraVM.Id_medico;
                nuevoMuestraET.id_tipo_prueba = nuevoMuestraVM.Id_tipo_prueba;
                nuevoMuestraET.id_departamento = nuevoMuestraVM.Id_departamento;
                nuevoMuestraET.fecha_recepcion = nuevoMuestraVM.Fecha_recepcion;
                nuevoMuestraET.estado = nuevoMuestraVM.Estado;
                
                muestraServices.InsertarMuestra(nuevoMuestraET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarMuestra(MuestraVistaModelo nuevoMuestraVM)
        {
            muestra nuevoMuestraET = new muestra();
            try
            {
                nuevoMuestraET.id_muestra = nuevoMuestraVM.Id_muestra;
                nuevoMuestraET.id_paciente = nuevoMuestraVM.Id_paciente;
                nuevoMuestraET.id_medico = nuevoMuestraVM.Id_medico;
                nuevoMuestraET.id_tipo_prueba = nuevoMuestraVM.Id_tipo_prueba;
                nuevoMuestraET.id_departamento = nuevoMuestraVM.Id_departamento;
                nuevoMuestraET.fecha_recepcion = nuevoMuestraVM.Fecha_recepcion;
                nuevoMuestraET.estado = nuevoMuestraVM.Estado;

                muestraServices.ActualizarMuestra(nuevoMuestraET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<MuestraVistaModelo> ListarMuestra()
        {
            List<MuestraVistaModelo> resultadoVistaModelo = new List<MuestraVistaModelo>();
            var resultadoBD = muestraServices.ListarMuestras();
            try
            {
                foreach (muestra item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new MuestraVistaModelo
                    {

                        Id_muestra = item.id_muestra,
                        Id_paciente = item.id_paciente,
                        Id_medico = item.id_medico,
                        Id_tipo_prueba = item.id_tipo_prueba,
                        Id_departamento = item.id_departamento,
                        Fecha_recepcion = item.fecha_recepcion,
                        Estado = item.estado
                    });
                }
                return resultadoVistaModelo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        public bool EliminarMuestra(MuestraVistaModelo eliminarMuestraVM)
        {
            try
            {

                muestraServices.EliminarMuestra(eliminarMuestraVM.Id_muestra);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
