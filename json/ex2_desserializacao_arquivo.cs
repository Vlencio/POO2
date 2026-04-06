using Newtonsoft.Json;
using System;
using System.IO;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

class Program
{
    static void Main()
    {
        string conteudo = File.ReadAllText("aluno.json");
        Aluno aluno = JsonConvert.DeserializeObject<Aluno>(conteudo);

        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"Idade: {aluno.Idade}");
        Console.WriteLine($"Curso: {aluno.Curso}");
    }
}
