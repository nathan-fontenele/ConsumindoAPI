using System.Text.Json.Serialization;

namespace ConsumindoAPI.Modelo;

public class ApiModel
{
   private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

   [JsonPropertyName("song")]
    public string? Musica { get; set; }

   [JsonPropertyName("artist")]
    public string? Artista { get; set; }

   [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

   [JsonPropertyName("genre")]
    public string? Genero { get; set; }

   [JsonPropertyName("key")]
   public int Chave { get; set; }

    public string Tonalidade { get
      {
         return tonalidades[Chave];
      }
   }

   public void getInfo()
   {
      Console.WriteLine(Musica);
      Console.WriteLine(Artista);
      Console.WriteLine(Duracao/1000);
      Console.WriteLine(Genero);
      Console.WriteLine(Tonalidade);
   }
}
