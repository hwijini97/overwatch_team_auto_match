using System.Collections.Generic;

namespace 오버워치팀매칭
{
    public class Result
    {
        public List<User> aTeam;
        public List<User> bTeam;

        public Result(List<User> aTeam, List<User> bTeam)
        {
            this.aTeam = aTeam;
            this.bTeam = bTeam; 
        }
    }
}
