using System;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int quantidade = 0;
        Int32.TryParse(Console.ReadLine(), out quantidade);
        string[] parametros = new string[quantidade];
        for(int i = 0; i < quantidade; i++)
        {
            parametros[i] = Console.ReadLine();
            char[] chars = parametros[i].ToCharArray();
            int tentativas = 0;
            int posicao = 0;
            while(posicao < (chars.Length - 1))
            {
                if(chars[posicao].ToString() == chars[(posicao + 1)].ToString())
                    tentativas++;
                posicao++;
            }
            Console.WriteLine(tentativas.ToString());   
        }        
    }
}