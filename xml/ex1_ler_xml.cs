using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var doc = XDocument.Load("alunos.xml");

        foreach (var aluno in doc.Descendants("aluno"))
        {
            string nome  = aluno.Element("nome").Value;
            string curso = aluno.Element("curso").Value;
            Console.WriteLine($"Nome: {nome} | Curso: {curso}");
        }
    }
}
