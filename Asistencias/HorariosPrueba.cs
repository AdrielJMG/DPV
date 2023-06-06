using System;

public class Class1
{
	public static Class1()
	{
        public void MostrarHorarios()
        {
            var horariosRepositorios = new HorariosRepositorios();
            var horarios = new Horarios();
            horarios.Id = Guid.NewGuid();
            horarios.hsEntrada = 8;
            horarios.minEntrada = 25;
            horarios.hsSalida = 12;
            horarios.minSalida = 31;

            horariosRepositorios.Insert(horarios);

            Console.WriteLine(horarios.hsEntrada);
            Console.ReadKey();

        }
    }
}
