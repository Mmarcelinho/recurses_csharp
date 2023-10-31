namespace Delegates;

public class Program
{
    static void Main(string[] args)
    {
        var gerenciadorTarefas = new GerenciadorTarefas();

        // Registrando os métodos para serem chamados quando os eventos forem disparados
        gerenciadorTarefas.ConcluirTarefa += ConcluirTarefa;
        gerenciadorTarefas.HorarioCriacaoTarefa += HorarioCriacaoTarefa;

        gerenciadorTarefas.AdicionarTarefa(new Tarefa(1, "teste", false, "usuario"));
    }

    // Método que marca uma tarefa como concluída a partir de um evento
    static void ConcluirTarefa(Tarefa tarefa)
    {
        tarefa.Concluido = true;
        Console.WriteLine($"Tarefa Concluída: {tarefa.ToString()}");

    }
    // Método que imprime o horário de criação de uma tarefa a partir de um evento
    static void HorarioCriacaoTarefa(Tarefa tarefa) => Console.WriteLine($"Tarefa: {tarefa} - Horário da criação: {DateTime.Now}");
}
