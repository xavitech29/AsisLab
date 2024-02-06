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
    public class MuestraService
    {
        readonly IMuestraRepository muestraRepository;
        public MuestraService()
        {
            muestraRepository = new MuestraRepository();
        }
        public void InsertarMuestra(muestra nuevo)
        {
            muestraRepository.Add(nuevo);
        }

        public void ActualizarMuestra(muestra muestra)
        {
            muestraRepository.Update(muestra);
        }

        public IEnumerable<muestra> ListarMuestras()
        {
            return muestraRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarMuestra(int id)
        {
            muestraRepository.Delete(id);
        }
    }
}
