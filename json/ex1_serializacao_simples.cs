using Newtonsoft.Json;
using System;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main()
    {
        var livro = new Livro
        {
            Titulo = "Dom Casmurro",
            Autor = "Machado de Assis",
            Ano = 1899
        };

        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);
    }
}
