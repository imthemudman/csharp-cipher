using System;
using CSharpCipher;

class DotnetProgram
{
    private static void Main(string[] args)
    {
        Cipher cipher = new Cipher();

        // Testing encrpytion by a three letter shift
        Console.WriteLine(cipher.String("hello world", 3));

        // Testing decrpytion by a three lette shift
        Console.WriteLine(cipher.String("khoor zruog", -3));

        Console.ReadKey(true);
    }
}
