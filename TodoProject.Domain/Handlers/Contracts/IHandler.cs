using System;
using System.Collections.Generic;
using System.Text;
using TodoProject.Domain.Commands.Contracts;

namespace TodoProject.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T: ICommand
    {
        ICommandResult Handle(T command);
    }
}
