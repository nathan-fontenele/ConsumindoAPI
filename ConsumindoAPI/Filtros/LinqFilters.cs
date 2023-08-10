using ConsumindoAPI.Modelo;

namespace ConsumindoAPI.Filtros;
internal class LinqFilters
{
   public static void getAllGenres(List<ApiModel> musicas)
   {
      var allGenres = musicas.Select(genre => genre.Genero).Distinct().ToList();

      foreach (var item in allGenres)
      {
         Console.WriteLine($"- {item}");
      }
   }

   public static void orderByArtistName(List<ApiModel> musicas)
   {
      var artistName = musicas.OrderBy(artist => artist.Artista).Select(musica => musica.Artista).Distinct().ToList();

      foreach (var item in artistName)
      {
         Console.WriteLine($"- {item}");
      }
   }

   public static void artistByGende(List<ApiModel> musicas, string genero)
   {
      var artist = musicas.Where(musica => musica.Genero.Contains(genero)).Select(artista => artista.Artista).Distinct().ToList();

      foreach (var item in artist)
      {
         Console.WriteLine($"- {item}");
      }
   }

   public static void musicsByArtist(List<ApiModel> musicas, string artista)
   {
      var musics = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Musica).Distinct().ToList();

      foreach (var item in musics)
      {
         Console.WriteLine($"- {item}");
      }
   }

   public static void musicsByTon(List<ApiModel> musicas, int tonalidade)
   {
      var musics = musicas.Where(musica => musica.Chave!.Equals(tonalidade)).Select(musica => musica.Musica).Distinct().ToList();

      foreach (var item in musics)
      {
         Console.WriteLine($"- {item}");
      }
   }
}
