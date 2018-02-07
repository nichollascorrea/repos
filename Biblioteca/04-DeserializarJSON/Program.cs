using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Biblioteca;


namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //le o arquivo JSON
            StreamReader sr = new StreamReader(@"C:\escritac\02_SerializarJSON.json");

            string deserializaJson = sr.ReadToEnd();

            //deserializa
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            //faz o cast
            Usuario usuario = (Usuario)serializador.Deserialize(deserializaJson, typeof(Usuario));

            Console.WriteLine("Usuário (Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);

            //deserialize<> é generics

            Console.ReadLine();



        }
    }
}
