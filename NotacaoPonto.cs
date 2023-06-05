using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos {
    public class NotacaoPonto {
        public static void NotaPonto() {
            var saudacao = "olá".ToUpper().Insert(3, " word!").Replace("Word!", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            String valorImportante = null;
            Console.WriteLine(valorImportante);
        }
    }
}

/*
 
    Links para consultas:
    https://www.udemy.com/course/curso-c-sharp/learn/lecture/10856394#questions/4950496
    
    Observações:
    Seguem aulas do professor Leonardo Leitão (udemy)

    - Atraves da notação ponto poderemos acessar funcionalidade
      dentro da propria propriedade.
    - Um exemplo disso é a propriedade (Length) retorna quantidade
      de caracteres atual.
    - Uma nuncia entre elementos com () em frente 
      é um `metodo`, enquanto sem () é uma propriedade.
    - Ao atribuirmos o null a uma variavel indica a ausencia de um objeto
 
 */