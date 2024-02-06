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
    public class TipoPruebaService
    {
        readonly ITipoPruebaRepository tipoPruebaRepository;
        public TipoPruebaService()
        {
            tipoPruebaRepository = new TipoPruebaRepository();
        }
        public void InsertarTipoPrueba(tipo_prueba nuevo)
        {
            tipoPruebaRepository.Add(nuevo);
        }

        public void ActualizarTipoPrueba(tipo_prueba tipo_Prueba)
        {
            tipoPruebaRepository.Update(tipo_Prueba);
        }

        public IEnumerable<tipo_prueba> ListarTipoPruebas()
        {
            return tipoPruebaRepository.GetAll();
        }
        //DELETE PARA FINES EDUCATIVO
        public void EliminarTipoPrueba(int id)
        {
            tipoPruebaRepository.Delete(id);
        }
    }
}
