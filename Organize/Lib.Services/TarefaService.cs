using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Data;
using Lib.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lib.Services
{
    public class TarefaService
    {

        private AplicationDbContext aplicationDbContext;

        public TarefaService()
        {
            aplicationDbContext = new AplicationDbContext();
        }

        public List<Tarefa> ConsultarTodos()
        {
            var tarefas = aplicationDbContext.Tarefas.ToList();
            if (tarefas == null)
                return new List<Tarefa>();

            return tarefas;
        }

        public Data.Entities.Tarefa Consultar(int id)
        {
            var task = aplicationDbContext.Tarefas.Where(tb => tb.Id == id).FirstOrDefault();

            if (task != null)
                return task;

            return new Tarefa();
        }

        public void Adicionar(Tarefa tarefa)
        {
            tarefa.Id = 0;
            aplicationDbContext.Tarefas.Add(tarefa);
            aplicationDbContext.SaveChanges();
        }

        public void Feito(Tarefa tarefa)
        {
            var tarefaDal = aplicationDbContext.Tarefas.Where(t => t.Id == tarefa.Id).FirstOrDefault();
            tarefaDal.Feito = !tarefaDal.Feito;
            aplicationDbContext.SaveChanges();
        }



        public void Excluir(int id)
        {
            var tarefa = Consultar(id);

            if (tarefa != null)
            {
                aplicationDbContext.Tarefas.Remove(tarefa);
                aplicationDbContext.SaveChanges();
            }
        }

        public void Limpar()
        {
            var lista = aplicationDbContext.Tarefas;
            aplicationDbContext.Tarefas.RemoveRange(lista);
            aplicationDbContext.SaveChanges();
        }
    }
}
