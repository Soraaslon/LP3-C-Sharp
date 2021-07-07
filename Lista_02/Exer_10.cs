using System;

namespace Exer_10
{
    class Exer_10
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3;

            Console.WriteLine("Digite as três notas da prova em sequência, de 0 a 100 (a 1° e 2° tem peso 1, já a 3° tem peso 2): ");
            nota1 = float.Parse(Console.ReadLine()) * 0.25f;
            nota2 = float.Parse(Console.ReadLine()) * 0.25f;
            nota3 = float.Parse(Console.ReadLine()) * 0.5f;

            float media = nota1 + nota2+nota3;
            Console.WriteLine("A média é: " + media);
            Console.WriteLine("O aluno foi " + (media >= 60 ? "aprovado" : "reprovado"));
        }
    }
}
