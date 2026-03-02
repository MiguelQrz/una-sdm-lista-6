using static System.Console;
try {
WriteLine("Digite o nome de um pokemon: ");
string pokemon = ReadLine().Trim()!;    
WriteLine($"Consultando o pokemon ({pokemon})...");
var client = new HttpClient();
var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemon}");
response.EnsureSuccessStatusCode();
var content = await response.Content.ReadAsStringAsync();
var pokeInfo = System.Text.Json.JsonSerializer.Deserialize<ConsumerPokeApi.models.PokeModel>(content);
if (pokeInfo != null)
{
    WriteLine($"Id: {pokeInfo.Id}");
    WriteLine($"Nome: {pokeInfo.Name}");
    WriteLine($"Altura: {pokeInfo.Height}");
    WriteLine($"Peso: {pokeInfo.Weight}");
    }
}
catch (Exception e)
{
    WriteLine($"Um erro ocorreu. Tente novamente. Detalhes: {e.Message}");
}