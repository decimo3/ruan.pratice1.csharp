using System.IO;
using exceptions;
namespace linguagens {
    public class traducoes {
        private string[] linhas = new string[100];
        public traducoes (string lang) {
            if (lang == "") {
                throw new ArgumentException("Parameter cannot be void");
            }
            int counter = 0;
            string line;
            // Read the file and display it line by line.
            StreamReader file = new StreamReader("./lang/" + lang + ".txt");
            while((line = file.ReadLine()) != null)
            {
                linhas[counter] = line;
                counter++;
            }
            file.Close();
            if (linhas[0] == "") {
                throw new ArgumentException("Text is not found!");
            }
        }
        public string getTexto (int a) {
            return linhas[a];
        }
    }
}
