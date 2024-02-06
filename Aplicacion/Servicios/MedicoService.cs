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
    public class MedicoService
    {
        readonly IMedicoRepository medicoRepository;
        public MedicoService()
        {
            medicoRepository = new MedicoRepository();
        }
        public void InsertarMedico(medico nuevo)
        {
            medicoRepository.Add(nuevo);
        }

        public void ActualizarMedico(medico medico)
        {
            medicoRepository.Update(medico);
        }

        public IEnumerable<medico> ListarMedicos()
        {
            return medicoRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarMedico(int id)
        {
            medicoRepository.Delete(id);
        }
    }
}
