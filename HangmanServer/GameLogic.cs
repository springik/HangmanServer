using MySql.Data.MySqlClient;

namespace HangmanServer
{
    internal class GameLogic
    {
        internal List<char> chosenWord { get; private set; }
        List<char> underscores;
        MySqlConnection connection;
        MySqlCommand command;

        public GameLogic()
        {
            ConnectToDB();
            ExecuteQuery("SELECT word FROM words ORDER BY RAND() LIMIT 1;");
            MakeUnderscores();
        }

        internal bool CheckInput(char input)
        {
            bool valid = false;
            for (int i = 0; i < chosenWord.Count; i++)
            {
                if (chosenWord[i] == input)
                {
                    underscores[i] = input;
                    valid = true;
                }
            }
            return valid;
        }
        void ConnectToDB()
        {
            connection = new MySqlConnection("server=localhost;uid=root;pwd=;database=hangmandb");
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        void ExecuteQuery(string query)
        {
            command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            chosenWord = reader.GetString(0).ToCharArray().ToList<char>();
        }
        void MakeUnderscores()
        {
            foreach (char c in chosenWord)
            {
                underscores.Add('_');
            }
        }
    }
}
