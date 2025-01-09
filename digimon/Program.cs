
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;


HttpClient client = new();
client.BaseAddress = new("https://digi-api.com/api/v1/");
HttpResponseMessage respone = client.GetAsync("digimon/angewomon").Result;
Digimon d = respone.Content.ReadFromJsonAsync<Digimon>().Result;


// string angewomon = respone.Content.ReadAsStringAsync().Result;

// File.WriteAllText("angewomon.json", angewomon);



Console.WriteLine(d.name);

Console.ReadLine();