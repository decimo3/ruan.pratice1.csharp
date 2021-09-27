// Usando as bibliotecas nativas do dotnet
using System;
using configuracoes;
using linguagens;

namespace ruan.console.csharp {
  class pontoDePartida {
    static void Main(string[] args) {
      // foreach (var arg in args) {
      //   Console.WriteLine(arg);
      // }
      configuracao cfg = new configuracao();
      traducoes lang = new traducoes(cfg.configData.lang);
      Console.WriteLine(cfg.configData.lang);
    }
  }
}
