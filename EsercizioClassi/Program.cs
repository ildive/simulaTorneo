namespace EsercizioClassi
{
    internal class Program
    {
        static dou
        static int minutiAttuali;
        static void Main(string[] args)
        {
            Squadra cerignola = new Squadra("Audace Cerignola");
            Squadra juve = new Squadra("Juventus");
        }

        static int numeroRandom(int n0, int n1)
        {
            Random rand = new Random();
            int nRandom = rand.Next(n0, n1+1);
            return nRandom;
        }

        static void scorriTempo()
        {


            for (int i = 0; i < 90; i++)
            {

            }
        }


        

        static void assegnaGoalSquadraRandom()
        {
            
        }
        static void iniziaPartita(Squadra squadra1, Squadra squadra2)
        {
            minutiAttuali = 0;
            assegnaGoalSquadraRandom(squadra1, squadra2);

            if(numeroRandom(0, 1) == 0) {
                squadra1.goalFatto();
            }
        }
    }
}
