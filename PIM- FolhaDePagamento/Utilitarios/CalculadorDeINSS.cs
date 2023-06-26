using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM__FolhaDePagamento.Utilitarios
{
    public class CalculaDescontoINSS
    {
        static double DescontoINSS; //Variavel a ser retornada
        public static double CalcularDescontoINSS(double salario) //Recebe o total de vencimentos como parametro para o calculo do inss
        {
            if (salario <= 1903.98)
            {

            }
            if (salario >= 1903.99 && salario <= 2826.65)
            {
                DescontoINSS = (salario / 100) * 7.5 / 100; //INSS = salario/100 * aliquota
            }
            if (salario >= 2826.66 && salario <= 3751.05)
            {
                DescontoINSS = (salario / 100) * 15 / 100;
            }
            if (salario >= 3751.06 && salario <= 4664.68)
            {
                DescontoINSS = (salario / 100) * 22.5 / 100;
            }
            if (salario > 4664.68)
            {
                DescontoINSS = (salario / 100) * 27.5 / 100;
            }
            return DescontoINSS; //retorno da função
        }
    }
}
