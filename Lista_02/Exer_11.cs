using System;

namespace Exer_11
{
    class Exer_11
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3;

            Console.WriteLine("    Digite as três notas na sequência, valendo de 0 a 10\nTrabalho de laborátorio: ");
            nota1 = float.Parse(Console.ReadLine()) * 0.2f;
            Console.WriteLine("Alaviação Semestral");
            nota2 = float.Parse(Console.ReadLine()) * 0.3f;
            Console.WriteLine("Exame final");
            nota3 = float.Parse(Console.ReadLine()) * 0.5f;

            float media = nota1 + nota2 + nota3;
            Console.WriteLine("A média é: " + media);
            if (media >= 0 && media < 3)
                Console.WriteLine("O aluno foi reprovado");
            else if (media >= 3 && media < 5)
                Console.WriteLine("O aluno está de recuperação");
            else if (media >= 5 && media <= 10)
                Console.WriteLine("O aluno foi aprovado");
        }
    }
}
