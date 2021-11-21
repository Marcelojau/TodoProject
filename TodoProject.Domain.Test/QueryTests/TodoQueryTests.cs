using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoProject.Domain.Entities;
using TodoProject.Domain.Queries;

namespace TodoProject.Domain.Test.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "usuarioM", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "usuarioM", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "marceloGomes", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "usuarioM", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "marceloGomes", DateTime.Now));
        }
        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_marcel()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("marceloGomes"));
            Assert.AreEqual(2, result.Count());
        }
    }
}
