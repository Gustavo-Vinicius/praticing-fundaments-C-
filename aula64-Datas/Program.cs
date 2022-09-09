using System.Globalization;

namespace aula64_Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var data = DateTime.Now;

            // var data = new DateTime(2022, 09, 09, 0, 0, 0);

            // OBTENDO DATAS 
            /* Console.WriteLine(data);
             Console.WriteLine(data.Year);
             Console.WriteLine(data.Month);
             Console.WriteLine(data.Day);
             Console.WriteLine(data.Hour);
             Console.WriteLine(data.Minute);
             Console.WriteLine(data.Second);
             Console.WriteLine(data.DayOfYear);*/

            // FORMATANDO DATAS
            // var formatada = String.Format("{0:r}", data);
            //var dia =  data.Month + 1 ;

            //ADICIONANDO VALORES
            /*Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));*/
            // DateTime? data = null;


            //COMPARANDO DATAS
            // var data = DateTime.Now;
            // if(data.Date == DateTime.Now.Date)
            //     Console.WriteLine("É igual");
            // Console.WriteLine(data);

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");

            Console.WriteLine(DateTime.Now);

        }
    }
}