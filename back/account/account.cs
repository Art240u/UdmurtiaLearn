namespace AccountModel
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public int Level { get; set; } = 1;
        public int Streack { get; set; } = 0;
        // public string password { get; set; } = ""

        public bool CanChangeName(string newName, out string changeError)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                changeError = "! Пустое поле";
                return false;
            }
            if (newName == Username)
            {
                changeError = "! Имя повторяется";
                return false;
            }
            changeError = null;
            return true;
        }

        public void LvlInc ()
        {
            Level = Level + 1
        }

        public void LvlSet (int LevelThatSets)
        {
            Level = LevelThatSets
        }
        
        public void ChangeName(string newName)
        {
            Username = newName;
        }
    }
}
