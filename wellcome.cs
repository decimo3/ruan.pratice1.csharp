using System;
using account;
namespace wellcome {
  class Wellcome {
    private char novato;
    public Wellcome () {
      bool loop = true;
      Console.WriteLine("Bem vindo ao mundo \"sem nome\"!");
      while (loop) {
        Console.WriteLine("Você é novo por aqui?");
        novato = Convert.ToChar(Console.Read());
        switch (novato) {
          case '1':
          case 'y':
          case 's':
          case 'S': 
          case 'Y': Console.WriteLine("Então vamos criar uma conta para você!");
          loop = false;
          break;
          case '0':
          case 'n':
          case 'N': Console.Write("\nEntão me informe seu usuário e senha:");
          loop = false;
          break;
          default: Console.WriteLine("Selecione uma opção válida!");
          break;
        }    
      }
    }
  }
}