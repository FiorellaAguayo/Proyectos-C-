using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player
    {
        private int _id;
        private string _name;
        private int _gamesPlayed;
        private float _goalAverage;
        private int _totalGoals;

        private Player ()
        {
            _gamesPlayed = 0;
            _goalAverage = 0;
            _totalGoals = 0;
        }

        public Player(int id, string name) : this()
        {
            _id = id;
            _name = name;
        }

        public Player(int dni, string name, int gamesPlayed, int totalGoals) : this(dni, name)
        {
            _gamesPlayed = gamesPlayed;
            _totalGoals = totalGoals;
        }

        public float GetGoalAverage()
        {
            return (float)_totalGoals / _gamesPlayed;
        }

        public string ShowData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {_id}");
            sb.AppendLine($"Name: {_name}");
            sb.AppendLine($"Games Played: {_gamesPlayed}");
            sb.AppendLine($"Total Goals: {_totalGoals}");
            sb.AppendLine($"Goal Average: {_goalAverage}");

            return sb.ToString();
        }

        public static bool operator ==(Player playerOne, Player PlayerTwo)
        {
            return playerOne._id == PlayerTwo._id;
        }

        public static bool operator !=(Player playerOne, Player PlayerTwo)
        {
            return !(playerOne._id == PlayerTwo._id);
        }
    }
}