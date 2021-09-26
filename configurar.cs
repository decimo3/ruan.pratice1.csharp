
using System;
using System.IO;
using System.Text.Json;
namespace configuracoes
{
  class configurar
  {
    public string lang { get; set; }
  }
  class configuracao {
    public string lang { get; set; }
    private String fileName = "config.json";
    private configurar cfg = new configurar();
    public configuracao(String[] argumentos) {
      setConfig(argumentos);
    }
    public configuracao () {
      try {
        getConfig(fileName);
      } catch {
        Console.WriteLine("Erro ao recuperar as configurações do arquivo");
      }
    }
    public int setConfig(String[] argumentos) {
      // Montar função para definir configurações pelos argumentos válidos;
      return 0;
    }
    public int setConfig(string configuracao, string fileName) {

        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(configuracao, options);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine("Sucesso ao gravar as configurações");
        return 1;
    }
    public configurar getConfig(string fileName) {
        string jsonString = File.ReadAllText(fileName);
        configurar config = JsonSerializer.Deserialize<configurar>(jsonString);
        Console.WriteLine("Sucesso ao carregar as configurações");
        return config;
    }
    public configurar getConfig() {
      return cfg;
    }

  }

}
