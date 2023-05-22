using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}

class FootballPlayer : Person
{
    public string? Number { get; set; }
    public double Height { get; set; }
    public Team? Team { get; set; }
}

class Goalkeeper : FootballPlayer { }

class Defender : FootballPlayer { }

class Midfielder : FootballPlayer { }

class Striker : FootballPlayer { }

class Coach : Person { }

class Referee : Person { }

class Team
{
    public Coach? Coach { get; set; }
    public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();

    public double GetAverageAge()
    {
        int totalAge = 0;
        foreach (var player in Players)
        {
            totalAge += player.Age;
        }

        return (double)totalAge / Players.Count;
    }
}

class Game
{
    public Team? Team1 { get; set; }
    public Team? Team2 { get; set; }
    public Referee? Referee { get; set; }
    public List<Tuple<int, FootballPlayer>> Goals { get; set; } = new List<Tuple<int, FootballPlayer>>();

    public void AddGoal(int minute, FootballPlayer player)
    {
        Goals.Add(new Tuple<int, FootballPlayer>(minute, player));
    }

    public Team? GetWinner()
    {
        if (Goals.Count > 0)
        {
            return Goals[^1].Item2.Team;
        }
        else
        {
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Goalkeeper player1 = new Goalkeeper { Name = "Иван", Number = "1", Age = 28, Height = 185 };
        Defender player2 = new Defender { Name = "Петър", Number = "5", Age = 25, Height = 180 };
        Midfielder player3 = new Midfielder { Name = "Георги", Number = "10", Age = 32, Height = 175 };
        Striker player4 = new Striker { Name = "Николай", Number = "9", Age = 30, Height = 182 };

        Coach coach = new Coach { Name = "Михаил", Age = 45 };

        Team team = new Team
        {
            Coach = coach,
            Players = new List<FootballPlayer> { player1, player2, player3, player4 }
        };

        Referee referee = new Referee { Name = "Станимир", Age = 40 };

        Game game = new Game
        {
            Team1 = team,
            Team2 = team,
            Referee = referee
        };

        game.AddGoal(30, player3);

        Console.WriteLine("Резултат: " + (game.GetWinner()?.Coach?.Name ?? "Равен резултат"));
    }
}
