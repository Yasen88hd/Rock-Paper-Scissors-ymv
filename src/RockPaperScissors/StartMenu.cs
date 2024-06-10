using System;
using System.Text.Json;

namespace RockPaperScissors
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();

            //load player data into scoreboard if there is any
            SaveManager.LoadScores();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (name == "")
            {
                MessageBox.Show("Enter a name to play");
                return;
            }

            PlayerData data;
            //if player already exists - copy wins over
            if ((data = Scoreboard.data.FirstOrDefault(p => p.Name == name)) == null)
            {
                data = new PlayerData(name);
                Scoreboard.data.Add(data);
            }

            GameManager.data = data;


            RockPaperScissorsForm rpcForm = new RockPaperScissorsForm();
            rpcForm.Show();

            this.Hide();
            rpcForm.FormClosed += (s, args) => this.Close();
        }

        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveManager.SaveScores();
        }
    }

    static class GameManager
    {
        public static PlayerData data = null;
    }

    class PlayerData
    {
        public string Name;
        public int Wins = 0;

        public PlayerData(string name)
        {
            this.Name = name;
        }
    }

    static class Scoreboard
    {
        public static List<PlayerData > data = new List<PlayerData>();
    }
    class SaveManager
    {
        private static string filePath = "save.json";
        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true,
            WriteIndented = true
        };

        public static void LoadScores()
        {
            if (!File.Exists(filePath))
            {
                Scoreboard.data = new List<PlayerData>();
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            Scoreboard.data = JsonSerializer.Deserialize<List<PlayerData>>(jsonString, options);
        }

        public static void SaveScores()
        {
            string jsonString = JsonSerializer.Serialize(Scoreboard.data, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
}