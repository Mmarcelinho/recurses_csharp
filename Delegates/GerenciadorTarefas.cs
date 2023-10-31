namespace Delegates;

public delegate void GerenciarTarefa(Tarefa tarefa);

public class GerenciadorTarefas
{
    List<Tarefa> listaTarefas = new List<Tarefa>();

    // Eventos do tipo delegate que atuam como contêineres para métodos com a mesma assinatura
    public event GerenciarTarefa ConcluirTarefa;
    public event GerenciarTarefa HorarioCriacaoTarefa;
        
    public void AdicionarTarefa(Tarefa tarefa)
    {
        listaTarefas.Add(tarefa);
        // Chamando o EventHandler para disparar os eventos
        EventHandler(tarefa);
    }

    // Método que dispara os eventos
    private void EventHandler(Tarefa tarefa)
    {
        // Quando disparados, os eventos chamam todos os métodos registrados
        ConcluirTarefa(tarefa);
        HorarioCriacaoTarefa(tarefa);
    }
}