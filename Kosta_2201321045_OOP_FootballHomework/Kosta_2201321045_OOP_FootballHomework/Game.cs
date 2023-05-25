using Kosta_2201321045_OOP_FootballHomework.Team_Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta_2201321045_OOP_FootballHomework
{
    class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public AssistantReferee AssistantReferee1 { get; private set; }
        public AssistantReferee AssistantReferee2 { get; private set; }
        public List<Goal> Goals { get; private set; }
        public string Result { get; private set; }
        public Team Winner { get; private set; }

        public Game(Team team1, Team team2, Referee referee,
            AssistantReferee assistantReferee1, AssistantReferee assistantReferee2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
            Goals = new List<Goal>();
        }


        public void AddGoal(int minute, FootballPlayer player)
        {
            Goals.Add(new Goal { Minute = minute, Player = player });
        }

        public void SetResult(string result, Team winner)
        {
            Result = result;
            Winner = winner;
        }
    }
}
