using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static void Main(String[] args) 
    {        
        String parametroQuantidade = Console.ReadLine();
        int quantidade = Convert.ToInt32(parametroQuantidade);
        string[] parametros = new string[quantidade];
        
        for (int i = 0; i < quantidade; i++)
        {
            parametros[i] = Console.ReadLine();
            int tentativas = 0;
            if(parametros[i] == (ReverseString(parametros[i])))
                Console.WriteLine(tentativas.ToString());
            else
                Console.WriteLine(TransformaPalindromo(parametros[i]).ToString());
        }
        Console.ReadLine();
    }
        
    private static int TransformaPalindromo(string Word)
    {
        int tentativa = 0;
        char[] arrChar = Word.ToCharArray();
        char[] arrCharInverse = ReverseString(Word).ToCharArray();
        
        for (int i = 0; i < Word.Length; i++)
        {
            while(arrCharInverse[i] > arrChar[i])
            {
                tentativa++;
                arrCharInverse[i] = RetornarLetraDiminuida(arrCharInverse[i]);
            }
        }        
        return tentativa;
    }
    
    private static char RetornarLetraDiminuida(char de)
    {
        return (char)(((int) de) - 1);                
    }
    
    private static string ReverseString(string Word)
    {
       char[] arrChar = Word.ToCharArray();
       Array.Reverse(arrChar);
       string invertida = new String(arrChar);
       return invertida;
    }
}