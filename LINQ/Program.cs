using System.Linq;
using System.Collections.Generic;
namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Tarefa> listaTarefas = new List<Tarefa>();

        for (int i = 1; i <= 20; i++)
        {
            Tarefa novaTarefa = new Tarefa(i, $"Tarefa {i}", false, "Usuário");
            listaTarefas.Add(novaTarefa);
        }

        // Método First(): Retorna o primeiro elemento que atende a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método First()");
        var metodoFirst = listaTarefas.First(x => x.Id == 1);
        //var exceptionResult = tasksList.First(x => x.Id == 30);
        Console.WriteLine(metodoFirst);
        Console.WriteLine("------------------------------------");

        // Método FirstOrDefault(): Retorna o primeiro elemento que atende a uma condição ou um valor padrão se não houver nenhum.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método FirstOrDefault()");
        var metodoFirstOrDefault = listaTarefas.FirstOrDefault(x => x.Id == 2);
        //var nullResult = tasksList.FirstOrDefault(x => x.Id == 30);
        Console.WriteLine(metodoFirstOrDefault);
        Console.WriteLine("------------------------------------");

        // Método Single(): Retorna o único elemento que atende a uma condição, lançando uma exceção se houver mais de um.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Single()");
        var metodoSingle = listaTarefas.Single(x => x.Id == 3);
        //exceptionResult = tasksList.Single(x => x.Id % 2 == 0);
        Console.WriteLine(metodoSingle);
        Console.WriteLine("------------------------------------");

        // Método SingleOrDefault(): Retorna o único elemento que atende a uma condição ou um valor padrão se não houver nenhum ou mais de um.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método SingleOrDefault()");
        var metodoSingleOrDefault = listaTarefas.SingleOrDefault(x => x.Id == 4);
        //nullResult = tasksList.SingleOrDefault(x => x.Id % 2 == 0);
        Console.WriteLine(metodoSingleOrDefault);
        Console.WriteLine("------------------------------------");

        // Método Any(): Retorna verdadeiro se pelo menos um elemento atender a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Any()");
        var metodoAnyReturnTrue = listaTarefas.Any(x => x.Id % 20 == 0);
        var metodoAnyReturnFalse = listaTarefas.Any(x => x.Id % 21 == 0);
        Console.WriteLine(metodoAnyReturnTrue);
        Console.WriteLine(metodoAnyReturnFalse);
        Console.WriteLine("------------------------------------");


        // Método Select(): Projeta elementos em uma nova sequência com base em uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Select()");
        var metodoSelect = listaTarefas
        .Take(5)
        .Select(x => new { Id = x.Id, Titulo = x.Titulo })
        .ToList();
        metodoSelect.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método Where(): Retorna todos os elementos que atendem a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Where()");
        var metodoWhere = listaTarefas
        .Where(x => x.Id % 5 == 0)
        .ToList();
        metodoWhere.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método OrderBy(): Classifica a coleção em ordem crescente com base em uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método OrderBy()");
        var metodoOrderBy = listaTarefas
        .Take(5)
        .OrderBy(x => x.Id)
        .ToList();
        metodoOrderBy.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método OrderByDescending(): Classifica a coleção em ordem decrescente.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método OrderByDescending()");
        var metodoOrderByDescending = listaTarefas
        .Take(5)
        .OrderByDescending(x => x.Id)
        .ToList();
        metodoOrderByDescending.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método ToList(): Converte IEnumerable em List para mais manipulações.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("ToList()");
        var metodoToList = listaTarefas
        .Take(3)
        .ToList();
        metodoToList.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método ToDictionary(): Cria um dicionário a partir de uma coleção.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Dictionary<key,value>");
        Dictionary<int, Tarefa> dicionarioDeTarefas = listaTarefas.ToDictionary(key => key.Id, value => value);
        for (int i = 1; i <= 5; i++)
        {
            if (dicionarioDeTarefas.ContainsKey(i))
                Console.WriteLine(dicionarioDeTarefas[i]);

            else
                Console.WriteLine("Chave não existe");
        }

    }
    
}

