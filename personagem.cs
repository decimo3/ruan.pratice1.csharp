using System;
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
      // Questionaario para preenchimento das afinidades iniciais
      Console.WriteLine("Aventureiro, qual eh o seu nome?");
      return 200;
    }
  }
}
