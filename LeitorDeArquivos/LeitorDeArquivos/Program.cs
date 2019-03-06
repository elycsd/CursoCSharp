using System;
using System.IO;

namespace LeitorDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivo();
        }
        public static void LerArquivo()
        {
            string caminhoDoArquivo = @"D:\teste\arquivo1.txt";
            if (File.Exists(caminhoDoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.ReadLine();
                }
            }
        }
    }
}
