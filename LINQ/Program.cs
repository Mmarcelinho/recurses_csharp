using System.Linq;
namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Todo> tasksList = new List<Todo>();

        for (int i = 1; i <= 20; i++)
        {
            Todo newTask = new Todo(i, $"Tarefa {i}", false, "Usuário");
            tasksList.Add(newTask);
        }

        // Método First(): Retorna o primeiro elemento que atende a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método First()");
        var methodFirst = tasksList.First(x => x.Id == 1);
        //var exceptionResult = tasksList.First(x => x.Id == 30);
        Console.WriteLine(methodFirst);
        Console.WriteLine("------------------------------------");

        // Método FirstOrDefault(): Retorna o primeiro elemento que atende a uma condição ou um valor padrão se não houver nenhum.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método FirstOrDefault()");
        var methodFirstOrDefault = tasksList.FirstOrDefault(x => x.Id == 2);
        //var nullResult = tasksList.FirstOrDefault(x => x.Id == 30);
        Console.WriteLine(methodFirstOrDefault);
        Console.WriteLine("------------------------------------");

        // Método Single(): Retorna o único elemento que atende a uma condição, lançando uma exceção se houver mais de um.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Single()");
        var methodSingle = tasksList.Single(x => x.Id == 3);
        //exceptionResult = tasksList.Single(x => x.Id % 2 == 0);
        Console.WriteLine(methodSingle);
        Console.WriteLine("------------------------------------");

        // Método SingleOrDefault(): Retorna o único elemento que atende a uma condição ou um valor padrão se não houver nenhum ou mais de um.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método SingleOrDefault()");
        var methodSingleOrDefault = tasksList.SingleOrDefault(x => x.Id == 4);
        //nullResult = tasksList.SingleOrDefault(x => x.Id % 2 == 0);
        Console.WriteLine(methodSingleOrDefault);
        Console.WriteLine("------------------------------------");

        // Método Any(): Retorna verdadeiro se pelo menos um elemento atender a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Any()");
        var methodAnyReturnTrue = tasksList.Any(x => x.Id % 20 == 0);
        var methodAnyReturnFalse = tasksList.Any(x => x.Id % 21 == 0);
        Console.WriteLine(methodAnyReturnTrue);
        Console.WriteLine(methodAnyReturnFalse);
        Console.WriteLine("------------------------------------");


        // Método Select(): Projeta elementos em uma nova sequência com base em uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Select()");
        var MethodSelect = tasksList
        .Take(5)
        .Select(x => new { Id = x.Id, Titulo = x.Titulo })
        .ToList();
        MethodSelect.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método Where(): Retorna todos os elementos que atendem a uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método Where()");
        var MethodWhere = tasksList
        .Where(x => x.Id % 5 == 0)
        .ToList();
        MethodWhere.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método OrderBy(): Classifica a coleção em ordem crescente com base em uma condição.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método OrderBy()");
        var MethodOrderBy = tasksList
        .Take(5)
        .OrderBy(x => x.Id)
        .ToList();
        MethodOrderBy.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método OrderByDescending(): Classifica a coleção em ordem decrescente.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Método OrderByDescending()");
        var MethodOrderByDescending = tasksList
        .Take(5)
        .OrderByDescending(x => x.Id)
        .ToList();
        MethodOrderByDescending.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método ToList(): Converte IEnumerable em List para mais manipulações.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("ToList()");
        var MethodToList = tasksList
        .Take(3)
        .ToList();
        MethodToList.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("------------------------------------");

        // Método ToDictionary(): Cria um dicionário a partir de uma coleção.
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Dictionary<key,value>");
        Dictionary<int, Todo> TasksDictionary = tasksList.ToDictionary(key => key.Id, value => value);
        for (int i = 1; i <= 5; i++)
        {
            if (TasksDictionary.ContainsKey(i))
                Console.WriteLine(TasksDictionary[i]);

            else
                Console.WriteLine("Chave não existe");
        }

    }
    
}

