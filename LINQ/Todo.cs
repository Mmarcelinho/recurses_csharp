using System;

namespace LINQ;

public class Todo
{
     public Todo()
    {
        
    }  

    public Todo(int id, string titulo, bool concluido, string nomeUsuario) 
    {
        this.Id = id;
        this.Titulo = titulo;
        this.Concluido = concluido;
        this.Data = DateTime.Now;
        this.NomeUsuario = nomeUsuario;
   
    }

    public int Id { get; set; }

    public string Titulo { get; set; }

    public bool Concluido { get; set; }

    public DateTime Data { get; set; }

    public string NomeUsuario { get; set; }

    public override string ToString() =>
        $"Id: {Id} | Titulo: {Titulo} | Concluido: {Concluido} | Data: {Data.ToShortDateString()} | Usuário: {NomeUsuario}";
    
}
