using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioClassi
{
    internal class Squadra
    {
        private string nomeSquadra;
        private int goalsFatti;
        private int goalsRicevuti;
        private int partiteVinte;
        private int partitePerse;
        private int partitePareggiate;
        private int punti;

        public Squadra(string nomeSquadra)
        {
            goalsFatti = 0;
            goalsRicevuti = 0;
            partiteVinte = 0;
            partitePerse = 0;
            partitePareggiate = 0;
            this.nomeSquadra = nomeSquadra;
        }

        
        /*  Getter  */

        public string getNome()
        {
            return nomeSquadra;
        }

        public int getGoalsFatti()
        {
            return goalsFatti;
        }

        public int getGoalsRicevuti()
        {
            return goalsRicevuti;
        }

        public int getPartiteVinte()
        {
            return partiteVinte;
        }

        public int getPartitePerse()
        {
            return partitePerse;
        }

        public int getPartitePareggiate()
        {
            return partitePareggiate;
        }

        public int getPunti()
        {
            punti = (partiteVinte*3) + partitePareggiate;
            return punti;
        }

        public void goalFatto()
        {
            goalsFatti++;
        }

        public void goalSubito()
        {
            goalsRicevuti++;
        }

        public void vinto()
        {
            partiteVinte++;
        }

        public void perso()
        {
            partitePerse++;
        }

        public void pareggio()
        {
            partitePareggiate++;
        }
    }
    

}
