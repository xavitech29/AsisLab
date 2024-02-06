using Dominio.Modelo.Abstracciones;
using Dominio.Modelo.Entidades;
using Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class PacienteService
    {
        readonly IPacienteRepository pacienteRepository;
        public PacienteService()
        {
            pacienteRepository = new PacienteRepository();
        }
        public void InsertarPaciente(paciente nuevo)
        {
            pacienteRepository.Add(nuevo);
        }

        public void ActualizarPaciente(paciente paciente)
        {
            pacienteRepository.Update(paciente);
        }

        public IEnumerable<paciente> ListarPacientes()
        {
            return pacienteRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarPaciente(int id)
        {
            pacienteRepository.Delete(id);
        }
    }
}
