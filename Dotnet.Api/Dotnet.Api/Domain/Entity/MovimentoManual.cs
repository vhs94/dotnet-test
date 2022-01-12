namespace Dotnet.Api.Domain.Entity
{
    public class MovimentoManual
    {
        public short Mes { get; set; }
        public short Ano { get; set; }
        public short Lancamento { get; set; }
        public string CodProduto { get; set; }
        public string CodCosif { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMovimento { get; set; }
        public string CodUsuario { get; set; }
        public decimal Valor { get; set; }
    }
}
