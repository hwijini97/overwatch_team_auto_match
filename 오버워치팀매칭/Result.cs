using System.Collections.Generic;

namespace 오버워치팀매칭
{
    public class Result
    {
        public List<User> aTeam;
        public List<User> bTeam;
        public string aTeamHash;
        public string bTeamHash;
        public int aTeamAverage;
        public int bTeamAverage;
        public int aTeamPoint;
        public int bTeamPoint;

        public Result(List<User> aTeam, List<User> bTeam, int aTeamPoint, int bTeamPoint)
        {
            this.aTeam = aTeam;
            this.bTeam = bTeam;

            string hash = "";

            for(int i=0; i<aTeam.Count; i++)
            {
                hash += aTeam[i].name;
            }
            aTeamHash = hash;

            hash = "";

            for (int i = 0; i < bTeam.Count; i++)
            {
                hash += bTeam[i].name;
            }
            bTeamHash = hash;

            this.aTeamAverage = 
                (aTeam[0].scores.tank + aTeam[1].scores.tank +
                aTeam[2].scores.dps + aTeam[3].scores.dps +
                aTeam[4].scores.support + aTeam[5].scores.support) / 6;

            this.bTeamAverage = 
                (bTeam[0].scores.tank + bTeam[1].scores.tank +
                bTeam[2].scores.dps + bTeam[3].scores.dps +
                bTeam[4].scores.support + bTeam[5].scores.support) / 6;

            this.aTeamPoint = aTeamPoint;
            this.bTeamPoint = bTeamPoint;
        }
    }
}
