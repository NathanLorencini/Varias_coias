﻿using ByteBankIO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {

            var numeroDeBytesLidos = -1;
        

            var buffer = new byte[1024];//criando array Equivale a 1kb

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
            fluxoDoArquivo.Read(buffer, 0, 1024); // Aqui eu digo que vou povoar meu array da posição 0 ate a posição 1024

            Console.WriteLine($"Bytes lidsos: {numeroDeBytesLidos}");
            fluxoDoArquivo.Close();
            Console.ReadLine();
        }

    }


    static void EscreverBuffer(byte[] buffer)
    {

        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer);
        Console.Write(texto);
        /*
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }*/
    }




}

