using OMG.Domain.Base.Entities;
using OMG.Domain.ValueObjects;

namespace OMG.Domain.Entities.Pedido
{
    public class Cliente : Entity
    {
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
        public required Endereco Endereco { get; set; }
    }
}
