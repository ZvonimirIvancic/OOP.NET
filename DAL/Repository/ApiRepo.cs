using DAL.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ApiRepo : IRepo
    {
        private string TEAM_PATH;
        private string MATCHES_PATH;
        public ApiRepo(string? championship)
        {
            TEAM_PATH = championship == "0" ? @"https://worldcup-vua.nullbit.hr/men/teams/results" : @"https://worldcup-vua.nullbit.hr/women/teams/results";
            MATCHES_PATH = championship == "0" ? @"https://worldcup-vua.nullbit.hr/men/matches" : @"https://worldcup-vua.nullbit.hr/women/matches";
        }
        public List<Team> GetTeams()
        {
            var client = new RestClient(TEAM_PATH);
            var result = client.Execute<List<Team>>(new RestRequest());
            if (result.Content != null)
            {
                return JsonConvert.DeserializeObject<List<Team>>(result.Content) ?? new List<Team>();
            }
            else
            {
                return new List<Team>();
            }
        }

        public Team GetTeam(string? countryCode)
        {
            List<Team> teams = GetTeams();
            Team? team = teams.FirstOrDefault(t => t.FifaCode == countryCode);
            return team;
        }

        public List<StartingEleven> GetAllPlayersCountry(string? countryCode)
        {
            List<StartingEleven> players = new();
            var match = GetMatchesCountry(countryCode).First();
            players.AddRange(match.AwayTeam.Code == countryCode ? match.AwayTeamStatistics.StartingEleven : match.HomeTeamStatistics.StartingEleven);
            players.AddRange(match.AwayTeam.Code == countryCode ? match.AwayTeamStatistics.Substitutes : match.HomeTeamStatistics.Substitutes);
            return players;
        }


        public List<Match> GetAllMatches()
        {
            var client = new RestClient(MATCHES_PATH);

            var result = client.Execute<List<Match>>(new RestRequest());


            if (result.Content != null)
            {
                return JsonConvert.DeserializeObject<List<Match>>(result.Content) ?? new List<Match>();
            }
            else
            {
                return new List<Match>();
            }
        }

        public List<Match> GetMatchesCountry(string? countryCode)
        {
            List<Match> matches = new();
            var allMatches = GetAllMatches();
            matches.AddRange(allMatches.Where(m => m.AwayTeam.Code == countryCode || m.HomeTeam.Code == countryCode));
            return matches;
        }
    }
}
