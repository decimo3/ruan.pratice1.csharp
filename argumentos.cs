using System;
namespace argumentos {
  class tratarArgumentos {
    private string usuario;
    private string password;
    tratarArgumentos (string[] args) {
      if (args[0] == "") {
        Console.WriteLine("É necessário fornecer argumentos de login");
      } else {
        for (int i = 0; i < args.Length; i++) {
          switch (args[i]) {
            case "user": usuario = args[i+1];
            break;
            case "password": password = args[i+1];
            break;
          }
        }
      }
    }
  }
}