using System.Reflection;

namespace Aplicacao_PROVA.Models
{
    public class VendasModel
    {
        public int id { get; set; }
        public string Situacao {  get; set; }
        public string Data {  get; set; }
        public string Nome_cliente {  get; set; }
        public string Sobrenome_cliente { get; set; }
        public float Preco_da_venda {  get; set; }
    }
}
