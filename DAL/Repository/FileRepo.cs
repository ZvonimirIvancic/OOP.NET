using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class FileRepo
    {
        private const string DEL = ":";
        private const string CONFIG_PATH = @"../../../../Files/config.txt";
        private const string FAVS_PATH = @"../../../../Files/favs.txt";
        private const string SAVED_TEAM_PATH = @"../../../../Files/favteam.txt";

        public static void SaveConfig(string preferences)
        {
            File.WriteAllText(CONFIG_PATH, preferences);
        }

        public static bool HasConfig()
        {
            try
            {
                string[] temp = File.ReadAllLines(CONFIG_PATH);
                return temp.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Dictionary<string, string> GetConfig()
        {
            Dictionary<string, string> result = new();
            string[] lines = File.ReadAllLines(CONFIG_PATH);
            foreach (string line in lines)
            {
                string[] details = line.Split(DEL);
                result.Add(details[0], details[1]);
            }
            return result;
        }

        public static Dictionary<string, string> ReadConfig()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(CONFIG_PATH);
            foreach (string line in lines)
            {
                string[] details = line.Split(DEL);
                result.Add(details[0], details[1]);
            }
            return result;
        }

        public static void SaveTeam(string? teamCode)
        {
            File.WriteAllText(SAVED_TEAM_PATH, teamCode);
        }

        public static bool HasSavedTeam()
        {
            try
            {
                File.ReadAllLines(SAVED_TEAM_PATH);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static string GetSavedTeam()
        {
            if (HasSavedTeam())
            {
                return File.ReadAllText(SAVED_TEAM_PATH);
            }
            return null;
        }

        public static void SaveFavourites(List<StartingEleven> favouritePlayers)
        {
            StringBuilder sb = new StringBuilder();
            favouritePlayers.ForEach(p => sb.AppendLine("PLAYER: " + p.Name + DEL + p.Captain + DEL + p.Position));
            File.WriteAllText(FAVS_PATH, sb.ToString());
        }

        public static bool HasFavourites()
        {
            try
            {
                File.ReadAllLines(FAVS_PATH);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static List<StartingEleven> GetFavourites()
        {
            List<StartingEleven> favouritePlayers = new List<StartingEleven>();
            if (HasFavourites())
            {
                string[] lines = File.ReadAllLines(FAVS_PATH);
                foreach (var line in lines)
                {
                    string[] details = line.Split(DEL);
                    favouritePlayers.Add(new StartingEleven { Name = details[1], Captain = Convert.ToBoolean(details[2]), Position = details[3] });
                }
            }
            return favouritePlayers;
        }

    }
}

