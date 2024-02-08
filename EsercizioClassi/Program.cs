namespace EsercizioClassi
{
    internal class Program
    {
        static double probabilitaGoal;
        static int minutiAttuali;

        static void Main(string[] args)
        {
            Squadra cerignola = new Squadra("Audace Cerignola");
            Squadra juve = new Squadra("Juventus");

            iniziaPartita(cerignola, juve);
        }

        static int numeroRandom(int n0, int n1)
        {
            Random rand = new Random();
            int nRandom = rand.Next(n0, n1+1);
            return nRandom;
        }

        static void faiGoalCasuale(Squadra squadra1, Squadra squadra2)
        {
            if(numeroRandom(1,2) == 1)
            {
                squadra1.goalFatto();
                squadra2.goalSubito();
                Console.WriteLine($"Goal di {squadra1.getNome()} Fatto al minuto {minutiAttuali}'");
            }
            else
            {
                squadra2.goalFatto();
                squadra1.goalSubito();
                Console.WriteLine($"Goal di {squadra2.getNome()} Fatto al minuto {minutiAttuali}'");
            }
        }   

        static void iniziaPartita(Squadra squadra1, Squadra squadra2)
        {

            Console.WriteLine("Partita Iniziata");
            minutiAttuali = 0;
            const double k = 1.3;
            double probabilita = 1;

            for (int i = 0; i < 90; i++)
            {
                minutiAttuali++;
                probabilita *= k;

                if (probabilita > 80)
                    probabilita = 75;

                if ((numeroRandom((int) probabilita, 100)) == 100)
                {
                    faiGoalCasuale(squadra1, squadra2);
                    probabilita = minutiAttuali / 2*k;
                }                
            }
            Console.WriteLine("\n90' | Partita Finita! Risultati:\n");
            Console.WriteLine($"{squadra1.getNome()}: {squadra1.getGoalsFatti()} goal fatti\n{squadra2.getNome()}: {squadra2.getGoalsFatti()} goal fatti");
        }
    }
}
