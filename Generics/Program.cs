using System.Collections.Generic;
namespace Generics;
class Program
{
    static void Main(string[] args)
    {
        var listaTarefas = new List<Tarefa>();
        var listaHorariosTarefa = new List<HorarioTarefa<Tarefa>>();

        var tarefa1 = new Tarefa(1, "Tarefa1", false, "Usuario");
        var tarefa2 = new Tarefa(2, "Tarefa2", false, "Usuario");

        listaTarefas.Add(tarefa1);
        listaTarefas.Add(tarefa2);

        var horario1 = new HorarioTarefa<Tarefa>(1, tarefa1, DateTime.Now.AddHours(2));
        var horario2 = new HorarioTarefa<Tarefa>(1, tarefa2, DateTime.Now.AddHours(4));

        listaHorariosTarefa.Add(horario1);
        listaHorariosTarefa.Add(horario2);

        Console.WriteLine("Lista de tarefas e Horários");
        listaHorariosTarefa.ForEach(x => Console.WriteLine($"{x.Tarefa.ToString()} - {x.DataHora}"));
    }

}