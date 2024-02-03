using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepoFactory
    {
        public static IRepo GetRepo(string? championship) => new ApiRepo(championship);
    }
}

