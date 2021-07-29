using configuracoes;
using linguagens; 

namespace ruan.console.csharp
{
  class praticando
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Do nothing");
      var configuracao = new configInicial();
      var traducao = new traducoes(configuracao.getLanguage());
    }
  }
}
