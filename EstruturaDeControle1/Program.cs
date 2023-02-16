public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite a pontuaçao de um aluno A(0-1000):");
        var EstudanteA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a pontuaçao de um aluno B(0-1000):");
        var EstudanteB = int.Parse(Console.ReadLine());

        var NotaDiferente = EstudanteA - EstudanteB;

        Console.WriteLine("Utilizando if-else");

        if (NotaDiferente > 0){
            Console.WriteLine("Aluno A tem maior nota.");
        }else if (NotaDiferente == 0){
            Console.WriteLine("Empate.");
        }else{
            Console.WriteLine("Aluno B tem maior nota.");
        }

        Console.WriteLine("Utilizando swuit-case ");

        switch (NotaDiferente){
            case > 0:
            Console.WriteLine("Aluno A tem maior nota.");
            break;

            case 0:
            Console.WriteLine("Empate.");
            break;

            default:
            Console.WriteLine("Aluno B tem maior nota.");
            break;

        }

    }
}