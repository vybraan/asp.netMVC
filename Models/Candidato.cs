namespace teste2.Models {
    public class Candidato { 
        public int Id {get;set; }
        public string Nome {get;set; }
        public Curso ICurso {get;set; }
        public DateTime IData {get;set; }

        public Candidato(int Id, string Nome, DateTime IData) { 
            this.Id = Id;
            this.Nome = Nome;
            this.ICurso = ICurso;
            this.IData = IData;
        }
    }
}