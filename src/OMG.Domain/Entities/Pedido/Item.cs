using OMG.Domain.Base;
using OMG.Domain.Entities.Base;

namespace OMG.Domain.Entities.Pedido;
public class Item : Entity
{
    public required Produto Produto { get; set; }
    public required string Cor { get; set; }
    public required string Aroma { get; set; }
    public required int Quantidade { get; set; } = 1;
}

