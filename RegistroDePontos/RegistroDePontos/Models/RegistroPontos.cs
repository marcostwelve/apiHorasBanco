using System.ComponentModel.DataAnnotations;

namespace RegistroDePontos.Models
{
    public class RegistroPonto
    {
        public int Id { get; set; }
        public string? Nome {  get; set; }
        public DateTime DataAtual => DateTime.Now;
        public string EntradaExpediente { get; set; } = "00:00";
        public string EntradaAlmoco { get; set; } = "00:00";
        public string VoltaAlmoco { get; set; } = "00:00";
        public string SaidaExpediente { get; set; } = "00:00";
    }
}
