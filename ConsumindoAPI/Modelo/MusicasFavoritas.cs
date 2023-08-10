namespace ConsumindoAPI.Modelo;

public class MusicasFavoritas
{
   public string? Name { get; set; }
   public List<ApiModel> Favoritas { get; }


   public MusicasFavoritas(string nome)
   {
      Name = nome;
      Favoritas = new List<ApiModel>();
   }

   public void add(ApiModel musica)
   {
      Favoritas.Add(musica);
   }

   public void getFavoriteMusics()
   {
      Console.WriteLine(Name);

      foreach (var item in Favoritas)
      {
         Console.WriteLine($"{item.Musica} de {item.Artista}");
      }
   }
}
