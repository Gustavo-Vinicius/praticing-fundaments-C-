namespace aula60_funcoes_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = RetornaNome("Gustavo", "Borges");
            Console.WriteLine(nome);

        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            int idade = 20
            )
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }

    }
}
