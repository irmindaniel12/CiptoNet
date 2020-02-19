using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public interface IRepository <TEntity>
    {
        void Insertar(TEntity entity);
        void Actualizar(TEntity entity);
        void Eliminar(int id);
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();  
    }
}
