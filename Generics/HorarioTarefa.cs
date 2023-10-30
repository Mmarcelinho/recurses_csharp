namespace Generics;

public class HorarioTarefa<T> where T : class
{
    public HorarioTarefa(int id, T tarefa, DateTime dataHora)
    {
        Id = id;
        Tarefa = tarefa;
        DataHora = dataHora;

    }
    public int Id { get; set; }
    public T Tarefa { get; set; }
    public DateTime DataHora { get; set; }


}
