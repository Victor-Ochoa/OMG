using OMG.Domain.Base.Commands;
using OMG.Domain.Base.Handlers;
using OMG.Domain.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG.Domain.Handlers
{
    public class ColecaoHandler : IHandler<CreateColecaoCommand, ICommandResult>
    {
        public ICommandResult Handle(CreateColecaoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
