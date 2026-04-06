using Newtonsoft.Json.Linq;
using System;

class Program
{
    static void Main()
    {
        string json = @"{
            'Servidor': 'localhost',
            'Porta': 3306,
            'Usuario': 'admin'
        }";

        JObject config = JObject.Parse(json);
        Console.WriteLine($"Porta atual: {config["Porta"]}");

        config["Porta"] = 5432;

        Console.WriteLine("\nConfiguracao apos alterar a Porta:");
        Console.WriteLine(config.ToString());
    }
}
