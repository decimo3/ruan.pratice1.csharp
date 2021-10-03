using System;
using System.IO;
using System.Text.Json;
using defaultConfiguracao;
namespace config.file {
  class config2json {
    public int setConfig(string configuracao, string fileName) {
      var options = new JsonSerializerOptions { WriteIndented = true };
      string jsonString = JsonSerializer.Serialize(configuracao, options);
      File.WriteAllText(fileName, jsonString);
      Console.WriteLine("Sucesso ao gravar as configurações");
      return 1;
    }
    public configProps getConfig(string fileName) {
      string jsonString = File.ReadAllText(fileName);
      configProps config = JsonSerializer.Deserialize<configProps>(jsonString);
      Console.WriteLine("Sucesso ao carregar as configurações");
      return config;
    }
  }
}
