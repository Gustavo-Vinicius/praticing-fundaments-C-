namespace aula61_tipos_refarencias_tipos_valor
{
    class Program
    {

        // --MEMORIA E DIVIDIDA EM DUAS PARTES, HEAP E STACK
        // --HEAP ARMAZENA OS DADOS
        // --STACK ARMAZENA AS REFERENCIAS PARA OS DADOS

        static void Main(string[] args)
        {

            // int x = 25;
            // int y = x;

            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // x = 32;

            // Console.WriteLine(x);
            // Console.WriteLine(y);

            var arr = new string[2];
            arr[0] = "item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr2[0] = "item 2";
            
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

        }
    }
}