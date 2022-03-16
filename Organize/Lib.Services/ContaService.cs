using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Data;
using Lib.Data.Entities;
using Lib.Dto;
using Microsoft.EntityFrameworkCore;

namespace Lib.Services
{
    public class ContaService
    {

        private AplicationDbContext aplicationDbContext;

        public ContaService()
        {
            aplicationDbContext = new AplicationDbContext();
        }

        public List<Conta> ConsultarTodos()
        {
            var Contas = aplicationDbContext.Contas.ToList();
            if (Contas == null)
                return new List<Conta>();

            return Contas;
        }

        public Conta Consultar(int id)
        {
            var task = ConsultarTodos().Where(tb => tb.Id == id).FirstOrDefault();

            if (task != null)
                return task;

            return new Conta();
        }

        public void Excluir(int id)
        {
            var Conta = Consultar(id);

            if (Conta != null)
            {
                aplicationDbContext.Contas.Remove(Conta);
                aplicationDbContext.SaveChanges();
            }
        }

        public void Limpar()
        {
            aplicationDbContext.Contas.RemoveRange(ConsultarTodos());
            aplicationDbContext.SaveChanges();
        }


        public void ValidarCriar(CriarContaDto Conta)
        {
            if (Conta.Nome.Length <= 4)
                throw new Exception("O seu Login deve conter pelo menos 4 caracteres");
            if(Conta.Senha.Length <= 3)
                throw new Exception("A sua Senha deve conter pelo menos 3 caracteres.");
            if(Conta.RepetirSenha != Conta.Senha)
                throw new Exception("A senha repetida não condiz.");
        }

        public void Criar(CriarContaDto Conta)
        {
            ValidarCriar(Conta);
            aplicationDbContext.Contas.Add(new Conta { Email = Conta.Email, Nome = Conta.Nome, Senha = Conta.Senha, Tipo = 0, Referencia = "" });
            aplicationDbContext.SaveChanges();
        }

    }
}
