﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Orientacao.dominio
{
    class Pedido
    {
        public int codigo;
        public DateTime data;
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }
        public double valorTotal()
        {
            double soma = 0.0;
            for (int i = 0; i < itens.Count; i++)
            {
                soma = soma + itens[i].subTotal();

            }

            return soma;

        }

        public override string ToString()
        {
            string s = "Pedido: " + codigo
                + ", Data: " + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                + "Itens:\n";
            for (int i = 0; i < itens.Count; i++)
            {
                Console.WriteLine(itens[i]);
            }
            s = s + "Total do Pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;

        }
    }
}
