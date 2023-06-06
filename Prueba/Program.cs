using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asistencias.Model;
using Asistencias.Repositories;

namespace Prueba
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            HorariosPrueba.MostrarHorarios();
            PersonalPrueba.MostrarPersonal();
            AsistenciaPrueba.MostrarAsistencias();

            Console.ReadKey();   
        }

        

    }


}
