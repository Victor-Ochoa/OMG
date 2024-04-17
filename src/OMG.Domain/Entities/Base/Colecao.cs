using OMG.Domain.Base.Entities;

namespace OMG.Domain.Entities.Base;
public class Colecao : Entity
{
    public required string Nome { get; set; }
    public required ICollection<Produto> Produtos { get; set; } = [];
}

