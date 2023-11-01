namespace LINQ;

public class Tarefa
{
    public Tarefa() { }

    public Tarefa(int id, string titulo, bool concluido, string nomeUsuario)
    {
        Id = id;
        Titulo = titulo;
        Concluido = concluido;
        Data = DateTime.Now;
        NomeUsuario = nomeUsuario;
    }

    public int Id { get; set; }

    public string Titulo { get; set; }

    public bool Concluido { get; set; }

    public DateTime Data { get; set; }

    public string NomeUsuario { get; set; }

    public override string ToString() =>
        $"Id: {Id} | Titulo: {Titulo} | Concluido: {Concluido} | Data: {Data.ToShortDateString()} | Usuário: {NomeUsuario}";
}
