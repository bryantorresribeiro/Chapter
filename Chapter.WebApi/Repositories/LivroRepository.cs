﻿using Chapter.WebApi.Contexts;
using Chapter.WebApi.Models;
using System.Collections.Generic;
using System.Linq;
namespace Chapter.WebApi.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }
        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }
        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id);
        }
        public void Atualizar(int id, Livro livro)
        {
            Livro livroBuscado = _context.Livros.Find(id);
            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livroBuscado.Disponivel = livro.Disponivel;
            }
            _context.Livros.Update(livroBuscado);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            Livro livroBuscado = _context.Livros.Find(id);
            _context.Livros.Remove(livroBuscado);
            _context.SaveChanges();
        }

    }
}
