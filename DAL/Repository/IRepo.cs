using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepo
    {
        List<Match> GetAllMatches();
        List<StartingEleven> GetAllPlayersCountry(string? countryCode);
        List<Match> GetMatchesCountry(string? countryCode);
        Team GetTeam(string? countryCode);
        List<Team> GetTeams();
    }
}
