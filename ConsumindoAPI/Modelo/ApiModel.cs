using System.Text.Json.Serialization;

namespace ConsumindoAPI.Modelo;

public class ApiModel
{
   [JsonPropertyName("song")]
    public string? Musica { get; set; }

   [JsonPropertyName("artist")]
    public string? Artista { get; set; }

   [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

   [JsonPropertyName("genre")]
    public string? Genero { get; set; }

   public void getInfo()
   {
      Console.WriteLine(Musica);
      Console.WriteLine(Artista);
      Console.WriteLine(Duracao/1000);
      Console.WriteLine(Genero);
   }
}
