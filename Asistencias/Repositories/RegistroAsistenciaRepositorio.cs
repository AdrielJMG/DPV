using Asistencias.Data.Repositories.Base;
using Asistencias.Model;
using Asistencias.Repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Repositories
{
    public class RegistrosAsistenciaRepositorio : Context, IRegistrosAsistenciaRepositorio
    {
        public void Delete(RegistrosAsistencia coreObject)
        {
            var obj = DbContext.RegistrosAsistencia.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            DbContext.RegistrosAsistencia.Remove(obj);
            DbContext.SaveChanges();

            throw new NotImplementedException();
        }

        public RegistrosAsistencia GetItem(Guid id)
        {
            var obj = DbContext.RegistrosAsistencia.FirstOrDefault(x => x.Id == id);
            return obj;

        }

        public IList<RegistrosAsistencia> GetList()
        {
            return DbContext.RegistrosAsistencia.ToList();

        }

        public void Insert(RegistrosAsistencia coreObject)
        {
            DbContext.RegistrosAsistencia.AddOrUpdate(coreObject);
            DbContext.SaveChanges();

        }

        public void Update(RegistrosAsistencia coreObject)
        {
            var obj = DbContext.RegistrosAsistencia.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            obj.IdPersonal = coreObject.IdPersonal;
            obj.FechaHora = coreObject.FechaHora;
            obj.Foto = coreObject.Foto;
            obj.Movimiento = coreObject.Movimiento;
            obj.IdHorario = coreObject.IdHorario;
            DbContext.RegistrosAsistencia.AddOrUpdate(obj);
            DbContext.SaveChanges();

        }
    }
}