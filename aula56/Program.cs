
namespace aula56
{
    class Program
    {
        static void Main(string [] args)
        {
            //ESTRUTURA CONDICIONAL ULTILIZANDO : SWITCH 
            string valor = "andre";

            switch (valor)
            {
                case "ana": Console.WriteLine("Não é o cara!"); break;

                case "anny": Console.WriteLine("Ainda não e a pessoa"); break;

                case "andre": Console.WriteLine("Yeee, esse é o cara !"); break;

                default: Console.WriteLine("Não foi encontrado a pessoa!"); break;
            }
        }
    }
}