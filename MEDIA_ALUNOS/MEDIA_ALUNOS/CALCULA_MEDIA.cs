using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIA_ALUNOS
{
    class CALCULA_MEDIA
    {

        public string aluno;
        public double trimestre1, trimestre2, trimestre3, media;

        public double calcula_media()
        {
            return trimestre1 + trimestre2 + trimestre3;

        }

        public string situacao()
        {
            if (calcula_media() >= 60.0)
            {
                return "Aprovado";

            }

            else
            {

                return "Reprovado"
                    + "\nFaltaram "
                    + 60.0 - calcula_media();
            }
        }

        public override string ToString()
        {
            return "NOME:"
                + aluno
                + "\nNOTA FINAL ="
                + calcula_media()
                + "\nSITUAÇÃO: "
                + situacao();
                
                }

    }
}
