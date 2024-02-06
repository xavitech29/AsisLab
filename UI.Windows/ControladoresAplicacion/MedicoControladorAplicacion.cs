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
    public class MedicoControladorAplicacion
    {
        private MedicoService medicoServices;

        public MedicoControladorAplicacion()
        {
            medicoServices = new MedicoService();
        }

        public bool InsertarMedico(MedicoVistaModelo nuevoMedicoVM)
        {
            medico nuevoMedicoET = new medico();
            try
            {

                nuevoMedicoET.nombre = nuevoMedicoVM.Nombre;
                nuevoMedicoET.apellido = nuevoMedicoVM.Apellido;
                nuevoMedicoET.especialidad = nuevoMedicoVM.Especialidad;
                nuevoMedicoET.telefono = nuevoMedicoVM.Telefono;
                nuevoMedicoET.email = nuevoMedicoVM.Email;
                
                medicoServices.InsertarMedico(nuevoMedicoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarMedico(MedicoVistaModelo nuevoMedicoVM)
        {
            medico nuevoMedicoET = new medico();
            try
            {

                nuevoMedicoET.id_medico = nuevoMedicoVM.Id_medico;
                nuevoMedicoET.nombre = nuevoMedicoVM.Nombre;
                nuevoMedicoET.apellido = nuevoMedicoVM.Apellido;
                nuevoMedicoET.especialidad = nuevoMedicoVM.Especialidad;
                nuevoMedicoET.telefono = nuevoMedicoVM.Telefono;
                nuevoMedicoET.email = nuevoMedicoVM.Email;
                medicoServices.ActualizarMedico(nuevoMedicoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<MedicoVistaModelo> ListarMedico()
        {
            List<MedicoVistaModelo> resultadoVistaModelo = new List<MedicoVistaModelo>();
            var resultadoBD = medicoServices.ListarMedicos();
            try
            {
                foreach (medico item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new MedicoVistaModelo
                    {

                        Id_medico = item.id_medico,
                        Nombre = item.nombre,
                        Apellido = item.apellido,
                        Especialidad = item.especialidad,
                        Telefono = item.telefono,
                        Email = item.email
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
    }
}
