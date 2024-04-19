  namespace ProjetoIndustria{

public class Program {
  public static void Main(string[] args){

    Industria industria= new Industria();
    industria.nome = "Kapazi";
    industria.localizacao = "Almirante Tamandaré";
    industria.anoFundacao = 1978;

    LinhaProducao linhaProducao1 = new LinhaProducao();
    linhaProducao1.numero = 1;
    linhaProducao1.tipo = "Tropical";
    linhaProducao1.capacidade = 200;

    LinhaProducao linhaProducao2 = new LinhaProducao();
    linhaProducao2.numero = 2;
    linhaProducao2.tipo = "Vinil";
    linhaProducao2.capacidade = 115;

    Maquina maquina1 = new Maquina();
    maquina1.id = 1;
    maquina1.marca = "Kapazi";
    maquina1.modelo = "CNC";

    Maquina maquina2 = new Maquina();
    maquina2.id = 2;
    maquina2.marca = "Kapazi";
    maquina2.modelo = "Calandra";

    Produto produto1 = new Produto();
    produto1.nome = "Tropical";
    produto1.codigo = 1;
    produto1.preco = 12;

    Produto produto2 = new Produto();
    produto2.nome = "Vinil";
    produto2.codigo = 2;
    produto2.preco = 19;

    industria.adicionarLinhaProducao(linhaProducao1);
    industria.adicionarLinhaProducao(linhaProducao2);

    linhaProducao1.adicionarMaquina(maquina1);
    linhaProducao2.adicionarMaquina(maquina2);

    maquina1.tipoProduto = produto1;
    maquina2.tipoProduto = produto2;

    System.Console.WriteLine("Indústria - Nome: " + industria.nome);
    System.Console.WriteLine("Indústria - Localização: " + industria.localizacao);
    System.Console.WriteLine("Indústria - Ano de fundação: " + industria.anoFundacao);

    for(int i = 0; i < 2; i++){
      System.Console.WriteLine(linhaProducao1);
    }


  }
}

  }