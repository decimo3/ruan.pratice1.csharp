
using System.IO;
using configuracoes;
namespace linguagens
{
    public class traducoes {
        private string[] linhas = new string[100];
        public traducoes (string lang) {
            int counter = 0;
            string line;
            // Read the file and display it line by line.  
            StreamReader file = new StreamReader(@"./lang/" + lang + ".txt");
            while((line = file.ReadLine()) != null)
            {
                linhas[counter] = line;
                counter++;
            }
            file.Close();
        }
        public string getTexto (int a) {
            return linhas[a];
        }
    }
}