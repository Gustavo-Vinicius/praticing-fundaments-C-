namespace aula62_struct
{
    class Program
    {
        // Classe principal.
        static void Main(string[] args)
        {
                Product mouse = new Product(1, "Gustavo", 165.96);

                Console.WriteLine(mouse.Id);
                Console.WriteLine(mouse.Name);
                Console.WriteLine(mouse.Price);
        }
    }

    //Inicialização de um struct.
    struct Product
    {
        public Product(int id, string name, double price){
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }

    }
}
