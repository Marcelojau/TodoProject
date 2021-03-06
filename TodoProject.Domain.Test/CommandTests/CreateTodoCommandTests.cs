using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TodoProject.Domain.Commands;

namespace TodoProject.Domain.Test.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("T?tulo da tarefa", "MarceloGomes", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }

    }
}
