using Microsoft.EntityFrameworkCore;
using Tarefas.API.Models;

namespace Tarefas.API.Context {
    public class TarefasDBContext : DbContext {

        public TarefasDBContext(DbContextOptions<TarefasDBContext> options) : base(options) {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
