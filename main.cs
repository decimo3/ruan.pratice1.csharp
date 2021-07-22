using System;
using Pessoa;

namespace ruan.console.csharp
{
    class praticando
    {
        static void Main(string[] args)
        {
            try
            {
                // Verifica se foi repassado argumentos
               if (args.Length == 0) {
                    throw new ArgumentException("Necessario que sejam fornecidos parametros!");
            } else
            {
                chamarNome saudar = new chamarNome(args[0]);
            } 
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
