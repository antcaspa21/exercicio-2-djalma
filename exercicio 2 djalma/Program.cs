namespace exercicio_2_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio2
            DateTime dataescolhida = new DateTime();

            string atibaia, bragança, mairipora, nazare, terrapreta, extrema, vargem;
            int codigo;

            Console.WriteLine("Escolha a cidade que deseja ir: \n1 - Atibaia, \n2 - Bragança Paulista, \n3 - Mairiporã, \n4 - Nazaré, \n5 - Terra Preta, \n6 - Extrema, \n7 - Vargem");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma data (dd/mm/aaaa):");
            dataescolhida = DateTime.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                atibaia = "Atibaia";
                Console.WriteLine(atibaia + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 2)
            {
                bragança = "Bragança Paulista";
                Console.WriteLine(bragança + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 3)
            {
                mairipora = "Mairiporã";
                Console.WriteLine(mairipora + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 4)
            {
                nazare = "Nazaré";
                Console.WriteLine(nazare + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 5)
            {
                terrapreta = "Terra Preta";
                Console.WriteLine(terrapreta + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 6)
            {
                extrema = "Extrema";
                Console.WriteLine(extrema + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if (codigo == 7)
            {
                vargem = "Vargem";
                Console.WriteLine(vargem + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else
            {
                Console.WriteLine("Código Inválido");
            }
            Console.ReadKey();
    }
    }
}