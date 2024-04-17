using OMG.Domain.Base.Commands;

namespace OMG.Domain.Base.Handlers;

public interface IHandler<T, TResult> 
    where T : ICommand 
    where TResult : ICommandResult
{
    TResult Handle(T command);
}