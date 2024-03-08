namespace _8MartIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo");
            string intput = Console.ReadLine();
            int[] arr = intput.Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join("," , intput));
        }
        static double CulculateAverage(int[] arr)
        {
            return arr.Sum() / arr.Length;
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join("," , arr));
        }
        static int CountZero(int[] arr)
        {
            return arr.Length;
            Console.WriteLine("Broi na nulite v masiva e");
        }
      

    }
}
