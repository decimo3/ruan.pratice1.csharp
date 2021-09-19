
using System;
using System.IO;
using linguagens; 
namespace configuracoes
{
  class configInicial
  {
    private string language;
    public configInicial()
    {
      bool c = true;
      try{
        getConfiguracao();
        c = true;
      } catch {
        setConfiguracao();
        c = false;
      } finally {
        var traducao = new traducoes(language);
        if (c)
        {
          Console.WriteLine(traducao.getTexto(3));
        } else {
          Console.WriteLine(traducao.getTexto(2));
        }
      }
    }
    private void getConfiguracao()
    {
      if (File.Exists(@"./config.ini"))
      {
        var counter = 0;
        string line;
        // Read the file and display it line by line.  
        StreamReader file = new StreamReader(@"./config.ini");
        while((line = file.ReadLine()) != null)
        {
          setLanguage(line);
        }
        file.Close();
      } else {
        throw new InvalidOperationException("Config file not found!");
      }
    } 
    private void setConfiguracao()
    {
      StreamWriter arquivo = File.AppendText(@"./config.ini");
        /*
        Console.Write("");
        //TODO: Questionario para registrar configuracoes basicas;
        arquivo.WriteLine("");
        */
      arquivo.Close();
    }
    public string getLanguage () {
      Console.WriteLine(language);
      if (language != "")
      {
      return language;
      } else {
        setLanguage("us");
        return language;
      }
    }
    private string setLanguage(string lang) {
      language = lang;
      return language;
    }
  }
}
