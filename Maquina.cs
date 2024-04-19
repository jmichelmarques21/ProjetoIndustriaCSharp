  namespace ProjetoIndustria{

  public class Maquina {
    public int id {get; set;}
    public string marca {get; set;}
    public string modelo {get; set;}
    public bool producao {get; set;}

    public Produto tipoProduto {get; set;}

    public string exibirInformacoes(){
      return this.id + " " + this.marca + " " + this.modelo;
    }

    public void iniciarProducao(){
      this.producao = true;
    }
  }

  }