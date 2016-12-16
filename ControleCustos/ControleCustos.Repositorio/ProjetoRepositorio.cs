﻿using System.Data.Entity;
using ControleCustos.Dominio;
using ControleCustos.Dominio.Interface;
using System.Collections;

namespace ControleCustos.Repositorio
{
    public class ProjetoRepositorio : IProjetoRepositorio
    {
        public Projeto Buscar(int id)
        {
            using (var context = new DatabaseContext())
            {
                return context.Projeto.Find(id);
            }
        }

        public void Inserir(Projeto projeto)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<Projeto>(projeto).State = EntityState.Added;
                if (projeto.Gerente != null)
                {
                    context.Entry<Usuario>(projeto.Gerente).State = EntityState.Unchanged;
                }
                context.SaveChanges();
            }
        }

        public void Atualizar(Projeto projeto)
        {
            using (var context = new DatabaseContext())
            {
                context.Entry<Projeto>(projeto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
