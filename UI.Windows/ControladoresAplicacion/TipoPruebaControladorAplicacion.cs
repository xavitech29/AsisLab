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
    public class TipoPruebaControladorAplicacion
    {
        private TipoPruebaService tipoPruebaServices;

        public TipoPruebaControladorAplicacion()
        {
            tipoPruebaServices = new TipoPruebaService();
        }

        public bool InsertarTipoPrueba(TipoPruebaVistaModelo nuevoTipoPruebaVM)
        {
            tipo_prueba nuevoTipoPruebaET = new tipo_prueba();
            try
            {

                nuevoTipoPruebaET.nombre_tipo_prueba = nuevoTipoPruebaVM.Nombre_tipo_prueba;
                nuevoTipoPruebaET.descripcion = nuevoTipoPruebaVM.Descripcion;
                
                tipoPruebaServices.InsertarTipoPrueba(nuevoTipoPruebaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarTipoPrueba(TipoPruebaVistaModelo nuevoTipoPruebaVM)
        {
            tipo_prueba nuevoTipoPruebaET = new tipo_prueba();
            try
            {
                nuevoTipoPruebaET.id_tipo_prueba = nuevoTipoPruebaVM.Id_tipo_prueba;
                nuevoTipoPruebaET.nombre_tipo_prueba = nuevoTipoPruebaVM.Nombre_tipo_prueba;
                nuevoTipoPruebaET.descripcion = nuevoTipoPruebaVM.Descripcion;

                tipoPruebaServices.ActualizarTipoPrueba(nuevoTipoPruebaET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<TipoPruebaVistaModelo> ListarTipoPrueba()
        {
            List<TipoPruebaVistaModelo> resultadoVistaModelo = new List<TipoPruebaVistaModelo>();
            var resultadoBD = tipoPruebaServices.ListarTipoPruebas();
            try
            {
                foreach (tipo_prueba item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new TipoPruebaVistaModelo
                    {

                        Id_tipo_prueba = item.id_tipo_prueba,
                        Nombre_tipo_prueba = item.nombre_tipo_prueba,
                        Descripcion = item.descripcion

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
