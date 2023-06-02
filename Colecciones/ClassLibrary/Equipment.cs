namespace ClassLibrary
{
    public class Equipment
    {
        private short _numbersOfPlayers;
        private List<Player> _players;
        private string _name;

        private Equipment()
        {
            _players = new List<Player>();
        }

        public Equipment(string name, short numbersOfPlayers) : this()
        {
            _name = name;
            _numbersOfPlayers = numbersOfPlayers;
        }

        public static bool operator +(Equipment equipment, Player player)
        {

            if (equipment._players.Count < equipment._numbersOfPlayers)
            {
                foreach (Player item in equipment._players)
                {
                    //utilizo sobrecarga de == de la clase Jugador
                    if (item == player)
                        return false;
                }
                equipment._players.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}