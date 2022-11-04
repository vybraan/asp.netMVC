
namespace teste2.Models {
    public class Curso { 
        public int Id {get;set; }
        public string Nome {get;set; }
        public string Disciplina {get;set; }
        public string Descricao {get;set; }

        public Curso(int Id, string Nome, string Disciplina, string Descricao) { 
            this.Id = Id;
            this.Nome = Nome;
            this.Disciplina = Disciplina;
            this.Descricao = Descricao;
        }
    }
}