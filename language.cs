using System;
using System.IO;
using System.Text.Json;
namespace linguagens
{
    public class traducoes {
        public string getText (string texto) {
            string jsonString = File.ReadAllText("linguagens.json");
            return "some text";
        }
    }
}