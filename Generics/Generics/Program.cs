using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Modelos;
using System.IO;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno" };
            Casa casa = new Casa() { Cidade = "Rio de Janeiro", Endereco = "Rua Duarte Coelho, 27" };
            Usuario usuario = new Usuario() { Nome = "Nichollas", Email = "nichollas@gmail.com", Senha = "senha" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro 2: " + carro2.Marca + " Modelo: " + carro2.Modelo);
            Console.WriteLine("Casa 2: " + casa2.Cidade + " Endereço: " + casa2.Endereco);
            Console.WriteLine("Usuario 2: " + usuario2.Nome + " Email: " + usuario2.Email + " Senha:" + usuario2.Senha);


            Console.ReadKey();

        }
    }
}
