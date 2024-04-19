  namespace ProjetoIndustria{

public class Produto {
  
  public string nome {get;set;}
  public int codigo {get;set;}
  public decimal preco {get;set;}

  public string exibirDetalhes(){
    return this.nome + " " + this.codigo + " " + this.preco;
  }

  public void atualizarPreco(decimal novoPreco) {
    this.preco = novoPreco;
  }
}

  }