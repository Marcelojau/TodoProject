
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TodoProject.Domain.Entities;

namespace TodoProject.Domain.Test.EntitiyTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo", "Marcelo", DateTime.Now);
        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            
            Assert.AreEqual(_validTodo.Done, false);
        }
    }
}
