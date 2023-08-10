using ConsumindoAPI.Filtros;
using ConsumindoAPI.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
   var reponse = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

   var musics = JsonSerializer.Deserialize<List<ApiModel>>(reponse) ;

   LinqFilters.musicsByTon(musics, 1);

   //MusicasFavoritas favorites = new MusicasFavoritas("Sergio");
   //favorites.add(musics[1]);
   //favorites.add(musics[423]);
   //favorites.add(musics[645]);
   //favorites.add(musics[234]);

   //favorites.getFavoriteMusics();

   //musics[265].getInfo();
   
}