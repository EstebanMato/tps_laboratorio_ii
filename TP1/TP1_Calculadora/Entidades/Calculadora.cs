using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación entre num1 y num2 segun el valor de operador, previa validación
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>La operacion realizada; Caso contrario la suma de ambos</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '-':
                    return num1 - num2;

                case '/':
                    return num1 / num2;

                case '*':
                    return num1 * num2;
                                        
                default:
                    return num1 + num2;
            }
        }

        /// <summary>
        /// Valida que el operador sea + - / *
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>El operador en caso de ser correcto; + caso contrario</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '/' || operador == '*')
                return operador;
            else
                return '+';
        }
    }
}
