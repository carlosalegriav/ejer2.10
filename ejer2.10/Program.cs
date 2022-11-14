namespace ejerciciodosdiez
{
    public class program
    {
        public static void Main()
        {
            double pulg = 0;
            double Mt = 0.0254;
            double Cpulg = 0;
            double MeDados = 0;
            Console.WriteLine("Dijite los metros necesitados");
            MeDados = double.Parse(Console.ReadLine());
            Cpulg = MeDados / Mt;

            Console.WriteLine($"La cantidad de pulgadas que se debe pedir es :{Cpulg}");

        }
    }
}
