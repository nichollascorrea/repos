﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes_WinForms.Classes
{
    class Cadastro
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }



        public Cadastro(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }

        public void PopulaResultos()
        {
            

        }
    }
}
