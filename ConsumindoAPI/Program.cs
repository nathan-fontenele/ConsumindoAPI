using ConsumindoAPI.Filtros;
using ConsumindoAPI.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
   var reponse = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

   var musics = JsonSerializer.Deserialize<List<ApiModel>>(reponse) ;

   LinqFilters.musicsByArtist(musics, "XXXTENTACION");


}