namespace Tarefas.API.Models {
    public class Tarefa {

        public Guid TarefaId { get; private set; }
        public string Nome { get; set; }
        public string Detalhes { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataConclusao { get; set; }

        public Categoria Categoria { get; private set; }
        public int CategoriaId { get; private set; }

        public Tarefa() {
            TarefaId = Guid.NewGuid();
            Nome = string.Empty;
            Detalhes = string.Empty;
            Concluida = false;
            DataCadastro = DateTime.Now;
            DataConclusao = null;
            CategoriaId = 0;
        }
    }
}