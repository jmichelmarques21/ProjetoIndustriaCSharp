UNIVERSIDADE POSITIVO
TÓPICOS ESPECIALS EM DESENVOLVIMENTO DE SOFTWARE
Atividade de Orientação a Objetos em C#
Você foi contratado(a) para desenvolver um sistema de gestão para uma indústria. O sistema deve ser capaz de gerenciar diferentes aspectos da produção, incluindo máquinas, produtos, linhas de produção e funcionários. A seguir, são fornecidas as especificações das classes envolvidas:

 Classe Indústria
- Atributos:
  1. Nome: o nome da indústria.
  2. Localização: a localização geográfica da indústria.
  3. AnoFundacao: o ano de fundação da indústria.

- Métodos:
  1. ExibirInformacoes(): exibe as informações da indústria, incluindo nome, localização e ano de fundação.
  2. AdicionarLinhaProducao(LinhaProducao linhaProducao): adiciona uma linha de produção à indústria.

 Classe LinhaProducao
- Atributos:
  1. Numero: o número da linha de produção.
  2. Tipo: o tipo de produto que a linha de produção fabrica.
  3. Capacidade: a capacidade de produção da linha (quantidade de produtos por hora).

- Métodos:
  1. ExibirDetalhes(): exibe os detalhes da linha de produção, incluindo número, tipo e capacidade.
  2. AdicionarMaquina(Maquina maquina): adiciona uma máquina à linha de produção.

 
 Classe Maquina
- Atributos:
  1. Id: o identificador da máquina.
  2. Marca: a marca da máquina.
  3. Modelo: o modelo da máquina.

- Métodos:
  1. ExibirInformacoes(): exibe as informações da máquina, incluindo identificador, marca e modelo.
  2. IniciarProducao(): simula o início da produção pela máquina.

 Classe Produto
- Atributos:
  1. Nome: o nome do produto.
  2. Codigo: o código do produto.
  3. Preco: o preço do produto.

- Métodos:
  1. ExibirDetalhes(): exibe os detalhes do produto, incluindo nome, código e preço.
  2. AtualizarPreco(decimal novoPreco): atualiza o preço do produto com o valor fornecido.

 Desafio:
- Implemente as classes conforme as especificações fornecidas.
- Crie uma indústria fictícia com pelo menos duas linhas de produção.
- Cada linha de produção deve ter pelo menos duas máquinas.
- Cada máquina deve produzir um tipo específico de produto.
- Exiba as informações completas da indústria, linhas de produção, máquinas e produtos.

Ao finalizar a implementação das classes e dos métodos, teste o sistema criando instâncias das classes e chamando os métodos necessários para exibir todas as informações.
