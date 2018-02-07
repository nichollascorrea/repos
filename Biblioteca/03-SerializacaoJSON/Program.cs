using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.Web.Script.Serialization;
using System.IO;

namespace _03_SerializacaoJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //JAVASCRIPT OBJECT NOTATION

            //Instanciando usuario
            Usuario usuario = new Usuario() { Nome = "Maria Costa", CPF = "333.333.333-00", Email = "maria@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objetoSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\escritac\02_SerializarJSON.json");

            
            sw.WriteLine(objetoSerializado);
            sw.Close();
            
        }
    }
}
