namespace ProjetoIndustria
{
    public class Industria {
        public string nome { get; set; }
        public string localizacao { get; set; }
        public int anoFundacao { get; set; }


        public List<LinhaProducao> linhas = new List<LinhaProducao>();

        public string exibirDetalhes(){
            return this.nome + " " + this.localizacao + " " + this.anoFundacao;
        }

        public void adicionarLinhaProducao(LinhaProducao linha){
            this.linhas.Add(linha);
        }
        
    }
}