﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada : {0}" , notaTruncada);

            Console.Write("Digite sua idade : ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida {0}  ", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeInteiro);
            Console.WriteLine("Resultado {0}" , idadeInteiro );

            Console.Write("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado : {0} ", numero);



            Console.Write("Digite o segundo número");
            int.TryParse(palavra, out  int numero2);
            Console.WriteLine("Resultado 2 : {0} " , numero2);

        }
    }
}
