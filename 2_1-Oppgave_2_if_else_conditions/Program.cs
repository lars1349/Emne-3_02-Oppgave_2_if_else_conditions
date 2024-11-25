namespace _2_1_Oppgave_2_if_else_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 6;
            int numb2 = 7;
            bool isEqual = false;
            int sum = numb1 + numb2;
            int sum2 = numb1 * numb2;

            if (numb1 == numb2) // Hvis nummerene er ulike, blir de lagt sammen.
            {
                isEqual = true;
                Console.WriteLine("Nummerene er like, og verdien er: " + sum2);
            }
            else // Hvis nummerene er like, blir de ganget sammen.
            {
                Console.WriteLine("Nummerene er ulike og summen av de to tallene er: " + sum);
            }

            Console.WriteLine("Er tallene like? " + isEqual);
        }
    }
}
