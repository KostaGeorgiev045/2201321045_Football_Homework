using Kosta_2201321045_OOP_FootballHomework;
using Kosta_2201321045_OOP_FootballHomework.Team_Members;

List<FootballPlayer> team1Players = new List<FootballPlayer>
{
            new GoalKeeper("P1T1", 20, 1, 185),
            new Defender("P2T1", 21, 2, 180),
            new Defender("P3T1", 22, 3, 177),
            new Midfield("P4T1", 21, 4, 175),
            new Midfield("P5T1", 20, 5, 165),
            new Striker("P6T1", 20, 6, 180),
            new Defender("P7T1", 7, 13, 179),
            new Defender("P8T1", 8, 7, 183),
            new Striker("P9T1", 22, 9, 185),
            new Striker("P10T1", 20, 10, 189),
            new Striker("P11T1", 21, 11, 178),
};

List<FootballPlayer> team2Players = new List<FootballPlayer>
{
            new GoalKeeper("P1T2", 20, 1, 184),
            new Defender("P2T2", 21, 2, 181),
            new Defender("P3T2", 22, 3, 178),
            new Midfield("P4T2", 21, 4, 174),
            new Midfield("P5T2", 20, 5, 166),
            new Striker("P6T2", 20, 6, 181),
            new Defender("P7T2", 7, 13, 178),
            new Defender("P8T2", 8, 7, 184),
            new Striker("P9T2", 22, 9, 184),
            new Striker("P10T2", 20, 10, 188),
            new Striker("P11T2", 21, 11, 177),
};

Team team1 = new Team(new Coach("CT1", 59), team1Players);
Team team2 = new Team(new Coach("CT2", 57), team2Players);

Referee referee = new Referee("R", 28);
AssistantReferee assistantReferee1 = new AssistantReferee("AR", 27);
AssistantReferee assistantReferee2 = new AssistantReferee("AR", 28);

Game game1 = new Game(team1, team2, referee, assistantReferee1, assistantReferee2);