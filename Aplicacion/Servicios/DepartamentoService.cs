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
    public class DepartamentoService
    {
        readonly IDepartamentoRepository departamentoRepository;
        public DepartamentoService()
        {
            departamentoRepository = new DepartamentoRepository();
        }
        public void InsertarDepartamento(departamento_laboratorio nuevo)
        {
            departamentoRepository.Add(nuevo);
        }

        public void ActualizarDepartamento(departamento_laboratorio departamento)
        {
            departamentoRepository.Update(departamento);
        }

        public IEnumerable<departamento_laboratorio> ListarDepartamentos()
        {
            return departamentoRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarPaciente(int id)
        {
            departamentoRepository.Delete(id);
        }
    }
}
