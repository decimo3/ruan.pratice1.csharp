using System;
using System.IO;
namespace linguagens
{
    public class traducoes {
        public traducoes (string lang) {
            string[] linhas = new string[100];
            int counter = 0;
            string line;
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"./lang/" + lang + ".txt");
            while((line = file.ReadLine()) != null)
            {
                linhas[counter] = line;
                counter++;
            }
            file.Close();
        }
    }
}