using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario usuario = new Usuario();
            //Cria os stream para leitura do XML
            StreamReader stream = new StreamReader(@"C:\escritac\01_SerializarXML.xml");

            //Le a Classe USUARIO
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            
            //faz o cast do xml para o 
            Usuario usuario = (Usuario)serializador.Deserialize(stream);


            //Exibe as informações 
            Console.WriteLine("Usuario(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            //Console.WriteLine("Usuário: " + usuario.Nome);
            //Console.WriteLine("CPF: " + usuario.CPF);
            //Console.WriteLine("Email: " + usuario.Email);

            Console.ReadLine();

        }
    }
}
