using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace Generics
{
    class Serializador
    {
        public static void Serializar(object obj)
        {
            JavaScriptSerializer serializar = new JavaScriptSerializer();

            string objetoSerializado = serializar.Serialize(obj);

            StreamWriter sw = new StreamWriter(@"C:\escritac\03_" + obj.GetType().Name + ".txt");

            sw.Write(objetoSerializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\escritac\03_" + typeof(T).Name + ".txt");
            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(conteudo, typeof(T));

            return obj;


        }
    }
}
