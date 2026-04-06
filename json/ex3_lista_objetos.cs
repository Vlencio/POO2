using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main()
    {
        var carros = new List<Carro>
        {
            new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2022 },
            new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2021 },
            new Carro { Marca = "Ford", Modelo = "Mustang", Ano = 2023 }
        };

        string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
        File.WriteAllText("carros.json", json);
        Console.WriteLine("Lista gravada em carros.json\n");

        string conteudo = File.ReadAllText("carros.json");
        var lista = JsonConvert.DeserializeObject<List<Carro>>(conteudo);

        foreach (var c in lista)
        {
            Console.WriteLine($"Marca: {c.Marca} | Modelo: {c.Modelo} | Ano: {c.Ano}");
        }
    }
}
