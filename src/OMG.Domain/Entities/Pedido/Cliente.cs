using OMG.Domain.Base;

namespace OMG.Domain.Entities.Pedido
{
    public class Cliente : Entity
    {
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
        public string Endereco { get; set; } = string.Empty;
    }
}
