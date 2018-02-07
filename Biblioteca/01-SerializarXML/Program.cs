using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESSE CÓDIGO CONVERTE O OBJETO PARA XML
            //instanciando o usuário
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "jose@gmail.com" };

            //instnciando o objeto de serilização
            //duas possíveis formas de fazer, mais utilizada é o typeof
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\escritac\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);






        }
    }
}
