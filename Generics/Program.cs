namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de tarefas
            var listaTarefas = new List<Tarefa>();

            // Cria uma lista de horários de tarefas parametrizada com o tipo Tarefa
            var listaHorariosTarefa = new List<HorarioTarefa<Tarefa>>();

            // Cria duas tarefas
            var tarefa1 = new Tarefa(1, "Tarefa1", false, "Usuario");
            var tarefa2 = new Tarefa(2, "Tarefa2", false, "Usuario");

            // Adiciona as tarefas à lista de tarefas
            listaTarefas.Add(tarefa1);
            listaTarefas.Add(tarefa2);

            // Cria dois horários de tarefas associados às tarefas
            var horario1 = new HorarioTarefa<Tarefa>(1, tarefa1, DateTime.Now.AddHours(2));
            var horario2 = new HorarioTarefa<Tarefa>(1, tarefa2, DateTime.Now.AddHours(4));

            // Adiciona os horários de tarefas à lista de horários de tarefas
            listaHorariosTarefa.Add(horario1);
            listaHorariosTarefa.Add(horario2);

            // Exibe a lista de tarefas e horários
            Console.WriteLine("Lista de tarefas e Horários");
            listaHorariosTarefa.ForEach(x => Console.WriteLine($"{x.Tarefa.ToString()} - {x.DataHora}"));
        }
    }
}
