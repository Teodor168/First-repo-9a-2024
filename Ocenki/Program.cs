namespace Ocenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklariram masiv ot 13 elementa
            double[] grades = new double[13];//{1,2,3,4,5,6};
            string[] names = new string[13] {"Lubo", "Milen", "Misho",
           "Rado", "Svetlo", "Siana", "Silviq"
            ,"Staskata", "Az", "Hristiqn", "Hristomir",
           "Cvetelina", "Cvetina"};
            //Vavejdane na elementite ot klaviaturata-cikul
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{i+14}. {names[i]} e ==>");
                grades[i] = double.Parse(Console.ReadLine());
            }
           
            //Obrabotka
            grades[8] = 6;
            names[8] = "Teodor";
            //Otpechatvane na rezultatite

            for(int j = 0;j < names.Length;j++)
            {
                Console.WriteLine($"na {j+14}. {grades[j]}");
            }

        }
    }
}
