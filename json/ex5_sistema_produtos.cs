using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class Produto
{
    [JsonProperty(Order = 1)]
    public int Id { get; set; }

    [JsonProperty("product_name", Order = 2, Required = Required.Always)]
    public string Nome { get; set; }

    [JsonProperty("product_price", Order = 3, Required = Required.Always)]
    public double Preco { get; set; }

    [JsonProperty(Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(Order = 5)]
    public string Fornecedor { get; set; }

    [JsonIgnore]
    public string CodigoInterno { get; set; }
}

class Program
{
    static void Main()
    {
        // Parte 2 - Criar lista de produtos
        var produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Notebook", Preco = 3500, Estoque = 10, Fornecedor = "Dell",     CodigoInterno = "NB-001" },
            new Produto { Id = 2, Nome = "Mouse",    Preco = 80,   Estoque = 50, Fornecedor = null,       CodigoInterno = "MS-002" },
            new Produto { Id = 3, Nome = "Teclado",  Preco = 150,  Estoque = 30, Fornecedor = "Logitech", CodigoInterno = "TC-003" }
        };

        // Parte 3 - Serializar para produtos.json (ignorando null - Parte 5)
        var settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        string json = JsonConvert.SerializeObject(produtos, Formatting.Indented, settings);
        File.WriteAllText("produtos.json", json);

        Console.WriteLine("=== produtos.json gerado ===");
        Console.WriteLine(json);

        // Parte 4 - Desserializar o JSON
        Console.WriteLine("\n=== Lendo produtos.json ===");
        string conteudo = File.ReadAllText("produtos.json");
        var lista = JsonConvert.DeserializeObject<List<Produto>>(conteudo);

        foreach (var p in lista)
        {
            Console.WriteLine($"Id: {p.Id} | Nome: {p.Nome} | Preco: {p.Preco} | Estoque: {p.Estoque} | Fornecedor: {p.Fornecedor ?? "N/A"}");
        }

        // Parte 6 - Campos obrigatorios (Nome e Preco sao Required.Always)
        Console.WriteLine("\n=== Testando JSON invalido (sem product_name) ===");
        string jsonInvalido = @"[{ ""Id"": 99, ""product_price"": 10.0, ""Estoque"": 5 }]";
        try
        {
            var invalidos = JsonConvert.DeserializeObject<List<Produto>>(jsonInvalido);
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine($"Erro esperado: {ex.Message}");
        }
    }
}
