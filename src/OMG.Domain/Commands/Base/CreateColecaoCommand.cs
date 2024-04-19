using OMG.Domain.Base.Commands;

namespace OMG.Domain.Commands.Base
{
    public class CreateColecaoCommand : ICommand
    {
        public required string NomeColecao { get; set; }
    }
}
