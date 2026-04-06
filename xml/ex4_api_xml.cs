using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

class Food
{
    public string Name  { get; set; }
    public string Price { get; set; }
}

class Program
{
    static async Task Main()
    {
        using var client = new HttpClient();
        string url = "https://www.w3schools.com/xml/simple.xml";

        string response = await client.GetStringAsync(url);
        var doc = XDocument.Parse(response);

        var foods = new List<Food>();

        foreach (var food in doc.Descendants("food"))
        {
            var item = new Food
            {
                Name  = food.Element("name")?.Value,
                Price = food.Element("price")?.Value
            };
            foods.Add(item);
            Console.WriteLine($"Nome: {item.Name} | Preco: {item.Price}");
        }
    }
}
