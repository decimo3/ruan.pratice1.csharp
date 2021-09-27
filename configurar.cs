using System;
using config.file;
using defaultConfiguracao;
namespace configuracoes {
  class configuracao {
    private config2json config = new config2json();
    public configProps configData = new configProps();
    private String fileName = "config.json";
    public configuracao () {
      try {
        configData = config.getConfig(fileName);
        Console.WriteLine("OK até aqui!");
      } catch {
        Console.WriteLine("Erro ao recuperar as configurações do arquivo");
      }
    }
    public configuracao(String[] argumentos) {
      // montar função para configurar através dos argumentos
    }
  }
}
