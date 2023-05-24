using Kosta_2201321045_OOP_FootballHomework.Team_Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta_2201321045_OOP_FootballHomework
{
    public class Team
    {
        public Coach Coach { get; private set; }
        public List<FootballPlayer> Players { get; private set; }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double GetAveragePlayerAge()
        {
            double totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return totalAge / Players.Count;
        }

    }
}
