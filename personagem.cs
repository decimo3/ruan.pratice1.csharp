using System;
using configuracoes;
using linguagens;

namespace personagem
{
  class personagens
  {
    private string nomePersonagem { get; set; }
    private int dataNascimento { get; set; }
    private int afinidadeForca { get; set; }
    private int afinidadeAgil { get; set; }
    private int afinidadeSaber { get; set; }

    public personagens () {
    }
    public int criarNovoPersonagem (string nome) {
      var configuracao = new configInicial();
      var traducao = new traducoes(configuracao.getLanguage());
      // Questionaario para preenchimento das afinidades iniciais
      Console.WriteLine(traducao.getTexto(0));
      Console.WriteLine(traducao.getTexto(1));

      return 200;
    }
  }
}
