using Asistencias.Data.Repositories.Base;
using Asistencias.Model;
using Asistencias.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Repositories
{
    public class HorariosRepositorios : Context, IHorariosRepositorios
    {
        public void Delete(Horarios coreObject)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            DbContext.Horarios.Remove(obj);
            DbContext.SaveChanges();
        }

        public Horarios GetItem(Guid id)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == id);
            return obj;
        }

        public IList<Horarios> GetList()
        {
            return DbContext.Horarios.ToList();
        }

        public void Insert(Horarios coreObject)
        {
            DbContext.Horarios.AddOrUpdate(coreObject);
            DbContext.SaveChanges();
        
        }

        public void Update(Horarios coreObject)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            obj.hsSalida = coreObject.hsSalida;
            obj.minSalida = coreObject.minSalida;
            obj.hsEntrada = coreObject.hsEntrada;
            obj.minEntrada = coreObject.minEntrada;
            DbContext.Horarios.AddOrUpdate(obj);
            DbContext.SaveChanges();

        }
    }
}
