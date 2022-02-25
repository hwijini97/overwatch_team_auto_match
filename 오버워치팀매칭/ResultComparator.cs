using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 오버워치팀매칭
{
    class ResultComparator : IEqualityComparer<Result>
    {
        public bool Equals(Result r1, Result r2)
        {
            return (r1.aTeamHash == r2.aTeamHash &&
               r1.bTeamHash == r2.bTeamHash) ||
               (r1.aTeamHash == r2.bTeamHash &&
               r1.bTeamHash == r2.aTeamHash);
        }

        public int GetHashCode(Result result)
        {
            return result.aTeamAverage + result.bTeamAverage;
        }
    }
}
