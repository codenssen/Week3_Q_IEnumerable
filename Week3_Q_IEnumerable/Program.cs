namespace Week3_Q_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // déclaration du tableau d'entier
            int[] intArray = new int[] { 1, 4, 7, 8, 16, 32, 24, 44, 64, 128, 256, 512 };
            Console.WriteLine("Entrez un chiffre entier :");
            int n = Convert.ToInt32(Console.ReadLine());

            // filtre du tableau
            int[] query = intArray.Where((x) => x <= n).ToArray();
            int sum = 0;

            // boucle d'affichage du tableau et calcul de la somme des entiers
            foreach (int i in query)
            {
                sum += i;
                Console.WriteLine(i);
            }

            // Affichage de la moyenne
            Console.WriteLine($"Moyenne : {(sum / query.Length)}");
        }
    }
}
