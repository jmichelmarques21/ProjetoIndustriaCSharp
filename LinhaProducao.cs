namespace ProjetoIndustria
{
    public class LinhaProducao {
        public int numero { get; set; } 
        public string tipo { get; set; }
        public int capacidade { get; set; }

        public List<Maquina> maquinas = new List<Maquina>();

        public string exibirDetalhes(){
            return this.numero + " " + this.tipo + " " + this.capacidade;
        }

        public void adicionarMaquina(Maquina maquina) {
            this.maquinas.Add(maquina);
        }
        
    }
}