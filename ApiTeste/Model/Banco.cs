using System.Text.Json.Serialization;

namespace ApiTeste.Model;
public class Banco
{
       public class Root
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("code")]
        public int Codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
    }
}
