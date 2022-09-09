namespace aula66_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new int [5]{1, 2, 3, 4, 5};

            // /*Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);*/

            // meuArray[0] =  12;

            // for(var index = 0; index <= meuArray.Length; index++)
            // {
            //     Console.WriteLine(meuArray[index]);
            // }

            // var funcionarios =  new Funcionario[5];
            // funcionarios[0] = new Funcionario() {Id = 2579, Nome = "Gustavo"};

            // foreach(var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Nome);
            // }

            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];
            primeiro.CopyTo(segundo, 0);

            primeiro[0] = 23;

            Console.WriteLine(segundo[0]);

        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }

        }
    }
}
