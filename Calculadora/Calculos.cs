using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculos
    {
        //classe responsável por fazer os cáculos
        //variável pública pode ser acessada por outras classes, variáveis privadas só pode ser lida pela sua própria classe
        public float  resultado;
        public float soma(float n1, float n2)
        {

            resultado = n1 + n2;
            return resultado;
        }

        public float multiplicação(float n1, float n2)
        {
            resultado = n1 * n2;
            return resultado;
        }

        public float subtração(float n1, float n2) 
        { 
            resultado = n1 - n2;
            return resultado;        
        }

        public float divisão(float n1, float n2)
        {
            resultado= n1 / n2;
            return resultado;
        }

        public float porcentagem(float n1)
        {
            resultado = n1 / 100;
            return resultado;
        }

    }
}
