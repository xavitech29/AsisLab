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
    public class PacienteControladorAplicacion
    {
        private PacienteService pacienteServices;

        public PacienteControladorAplicacion()
        {
            pacienteServices = new PacienteService();
        }

        public bool InsertarPaciente(PacienteVistaModelo nuevoPacienteVM)
        {
            paciente nuevoPacienteET = new paciente();
            try
            {
               
                nuevoPacienteET.nombre = nuevoPacienteVM.Nombre;
                nuevoPacienteET.apellido = nuevoPacienteVM.Apellido;
                nuevoPacienteET.fecha_nacimiento = nuevoPacienteVM.Fecha_nacimiento;
                nuevoPacienteET.genero = nuevoPacienteVM.Genero;
                nuevoPacienteET.direccion = nuevoPacienteVM.Direccion;
                nuevoPacienteET.telefono = nuevoPacienteVM.Telefono;
                pacienteServices.InsertarPaciente(nuevoPacienteET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarPaciente(PacienteVistaModelo nuevoPacienteVM)
        {
            paciente nuevoPacienteET = new paciente();
            try
            {
                nuevoPacienteET.id_paciente = nuevoPacienteVM.Id_paciente;
                nuevoPacienteET.nombre = nuevoPacienteVM.Nombre;
                nuevoPacienteET.apellido = nuevoPacienteVM.Apellido;
                nuevoPacienteET.fecha_nacimiento = nuevoPacienteVM.Fecha_nacimiento;
                nuevoPacienteET.genero = nuevoPacienteVM.Genero;
                nuevoPacienteET.direccion = nuevoPacienteVM.Direccion;
                nuevoPacienteET.telefono = nuevoPacienteVM.Telefono;
                pacienteServices.ActualizarPaciente(nuevoPacienteET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<PacienteVistaModelo> ListarPaciente()
        {
            List<PacienteVistaModelo> resultadoVistaModelo = new List<PacienteVistaModelo>();
            var resultadoBD = pacienteServices.ListarPacientes();
            try
            {
                foreach (paciente item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new PacienteVistaModelo
                    {
                     
                    Id_paciente = item.id_paciente,
                    Nombre = item.nombre,
                    Apellido = item.apellido,
                    Fecha_nacimiento = item.fecha_nacimiento,
                    Genero = item.genero,
                    Direccion = item.direccion,
                    Telefono = item.telefono
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

        public bool EliminarPaciente(PacienteVistaModelo eliminarPacienteVM)
        {            
            try
            {

                pacienteServices.EliminarPaciente(eliminarPacienteVM.Id_paciente);
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
