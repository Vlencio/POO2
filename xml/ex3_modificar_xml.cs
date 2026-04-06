using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        var doc = XDocument.Load("estoque.xml");

        var mouse = doc.Descendants("item")
            .FirstOrDefault(i => i.Element("nome").Value == "Mouse");

        if (mouse != null)
        {
            mouse.Element("quantidade").Value = "10";
            doc.Save("estoque.xml");
            Console.WriteLine("Quantidade do Mouse atualizada para 10.\n");
            Console.WriteLine(File.ReadAllText("estoque.xml"));
        }
        else
        {
            Console.WriteLine("Item 'Mouse' nao encontrado.");
        }
    }
}
