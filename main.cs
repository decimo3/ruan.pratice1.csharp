// Usando as bibliotecas nativas do dotnet
using System;
using configuracoes;

namespace ruan.console.csharp {
  class pontoDePartida {
    static void Main(string[] args) {
      // foreach (var arg in args) {
      //   Console.WriteLine(arg);
      // }
      configuracao cfg = new configuracao();
      Console.WriteLine(cfg.configData.lang);
    }
  }
}
