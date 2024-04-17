using OMG.Domain.Base;

namespace OMG.Domain.Entities.Base;

public class Produto : Entity
{
    public required string Nome { get; set; }
    public required float Valor { get; set; }
    public required Colecao Colecao { get; set; }
}

