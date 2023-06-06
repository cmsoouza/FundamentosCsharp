using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos {
    public class Interpolacao {
       public static void Inter() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            /* 1° Interpolaçao usando operador + */
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            /* 2 ° Interpolação usando indices */
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            /* 3° Interpolação usando $ */
            Console.WriteLine($"A marca {marca} é legal!");

            /* 4° Realizando operações em interpolação */
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }

        /* 5° Interpolação usando ingles substituição de valores*/
        public static void Inter2() {
            string firstName = "Cristian";
            string lastName = "Souza";
            string name = $"My full name is: {firstName} {lastName}";
            
            Console.WriteLine(name);
        }
    }
}

/* 
    Links para consultas:
    (Interpolação)
    https://www.w3schools.com/cs/cs_strings_interpol.php

    Observações:
    Explicações e comentarios segue as aulas udemy professor Leonardo

 */


