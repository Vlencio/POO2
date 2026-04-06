using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Program
{
    static void Main()
    {
        var produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Preco = 3500.00 },
            new Produto { Nome = "Mouse",    Preco = 80.00   },
            new Produto { Nome = "Teclado",  Preco = 150.00  }
        };

        var serializer = new XmlSerializer(typeof(List<Produto>));
        using (var writer = new StreamWriter("produtos.xml"))
        {
            serializer.Serialize(writer, produtos);
        }

        Console.WriteLine("Arquivo produtos.xml gerado:\n");
        Console.WriteLine(File.ReadAllText("produtos.xml"));
    }
}
