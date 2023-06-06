using Asistencias.Model;
using Asistencias.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class PersonalPrueba
    {
        public static void MostrarPersonal()

        {
            IPersonalRepositorio personalRepositorios = new PersonalRepositorios();
            var personal = new Personal();

            personal.Id = Guid.NewGuid();
            personal.Nombre = "Gino";
            personal.Apellido = "Solano";
            personal.DNI = "39229875";
            personal.Domicilio = "av.congreso 552 ";
            personal.FechaNac = DateTime.Now;
            personal.IdHorario = Guid.Parse("6FCAF6EB-A3AD-4628-9441-0B963E4A2D93");
          

            personalRepositorios.Insert(personal);

            Console.WriteLine(personal.Id);
            Console.WriteLine(personal.Nombre);
            Console.WriteLine(personal.Apellido);
            Console.WriteLine(personal.DNI);
            Console.WriteLine(personal.Domicilio);
            Console.WriteLine(personal.FechaNac);
             }


        }
}
