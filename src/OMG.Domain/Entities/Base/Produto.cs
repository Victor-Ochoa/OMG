using OMG.Domain.Base;

namespace OMG.Domain.Entities.Base;

public class Produto : Entity
{
    public string Nome { get; set; }
    public float Valor { get; set; }
    public Colecao Colecao { get; set; }
}

