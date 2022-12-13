using Api.Contexts;
using Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories{
    public class LivroRepository{
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context){
            _context = context;
        }
        public List<Livro> Listar(){
            return _context.Livro.ToList();
        }
    }
}