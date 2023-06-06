using Asistencias.Model;
using Asistencias.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public static class AsistenciaPrueba
    {
        public static void MostrarAsistencias()
        {
            IRegistrosAsistenciaRepositorio asistenciasRepositorios = new RegistrosAsistenciaRepositorio();
            var asistencia = new RegistrosAsistencia();

            asistencia.Id = Guid.NewGuid();
            asistencia.IdPersonal = Guid.Parse("7A609E66-A05A-42F9-84A8-F0262091A972");
            asistencia.FechaHora = DateTime.Now;
            asistencia.Movimiento = "s";
            asistencia.IdHorario = Guid.Parse("6FCAF6EB-A3AD-4628-9441-0B963E4A2D93");

            asistenciasRepositorios.Insert(asistencia);

            Console.WriteLine(asistencia.Id);
            Console.WriteLine(asistencia.IdPersonal);
            Console.WriteLine(asistencia.FechaHora);
            Console.WriteLine(asistencia.Movimiento);
            Console.WriteLine(asistencia.IdHorario);
            

        }


    }
}
