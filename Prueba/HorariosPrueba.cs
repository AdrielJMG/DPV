using Asistencias.Model;
using Asistencias.Repositories;
using System;

public static class HorariosPrueba
{

    public static void MostrarHorarios()
    {
        IHorariosRepositorios horariosRepositorios = new HorariosRepositorios();
        var horarios = new Horarios();
        horarios.Id = Guid.NewGuid();
        horarios.hsEntrada = 8;
        horarios.minEntrada = 30;
        horarios.hsSalida = 12;
        horarios.minSalida = 30;

        horariosRepositorios.Insert(horarios);
        Console.WriteLine(horarios.Id);
        Console.WriteLine("Entrada registrada a: " + horarios.hsEntrada + "hs");
        Console.WriteLine(horarios.minEntrada);
        Console.WriteLine(horarios.minSalida);
        Console.WriteLine(horarios.hsSalida);   
        

    }
}
