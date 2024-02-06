using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo.Abstracciones
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity); //Insertar
        void Delete(int id); //Eliminar
        void Update(TEntity entity); // Actualizar
        IEnumerable<TEntity> GetAll();//Select * from
        TEntity GetById(int id); // buscar por id

    }
}
