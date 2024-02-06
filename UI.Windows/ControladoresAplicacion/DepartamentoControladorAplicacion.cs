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
    public class DepartamentoControladorAplicacion
    {
        private DepartamentoService departamentoServices;

        public DepartamentoControladorAplicacion()
        {
            departamentoServices = new DepartamentoService();
        }

        public bool InsertarDepartamento(DepartamentoVistaModelo nuevoDepartamentoVM)
        {
            departamento_laboratorio nuevoDepartamentoET = new departamento_laboratorio();
            try
            {

                nuevoDepartamentoET.nombre_departamento = nuevoDepartamentoVM.Nombre_departamento;
                nuevoDepartamentoET.descripcion = nuevoDepartamentoVM.Descripcion;

                departamentoServices.InsertarDepartamento(nuevoDepartamentoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool ActualizarDepartamento(DepartamentoVistaModelo nuevoDepartamentoVM)
        {
            departamento_laboratorio nuevoDepartamentoET = new departamento_laboratorio();
            try
            {
                nuevoDepartamentoET.id_departamento = nuevoDepartamentoVM.Id_departamento;
                nuevoDepartamentoET.nombre_departamento = nuevoDepartamentoVM.Nombre_departamento;
                nuevoDepartamentoET.descripcion = nuevoDepartamentoVM.Descripcion;

                departamentoServices.ActualizarDepartamento(nuevoDepartamentoET);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<DepartamentoVistaModelo> ListarDepartamento()
        {
            List<DepartamentoVistaModelo> resultadoVistaModelo = new List<DepartamentoVistaModelo>();
            var resultadoBD = departamentoServices.ListarDepartamentos();
            try
            {
                foreach (departamento_laboratorio item in resultadoBD)
                {
                    resultadoVistaModelo.Add(new DepartamentoVistaModelo
                    {

                        Id_departamento = item.id_departamento,
                        Nombre_departamento = item.nombre_departamento,
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

        public bool EliminarDepartamento(DepartamentoVistaModelo eliminarDepartamentoVM)
        {
            try
            {

                departamentoServices.EliminarDepartamento(eliminarDepartamentoVM.Id_departamento);
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
