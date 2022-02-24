using System;

namespace 오버워치팀매칭
{
    public class ScoreByPosition
    {
        public int tank { get; set; }
        public int dps { get; set; }
        public int support { get; set; }
        public ScoreByPosition(int tank, int dps, int support)
        {
            this.tank = tank;
            this.dps = dps;
            this.support = support;
        }
    }
}
