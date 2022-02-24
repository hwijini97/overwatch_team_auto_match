using System;

namespace 오버워치팀매칭
{
    public class User
    {
        public string name { get; set; }
        public ScoreByPosition scores { get; set; }

        public User(String name, int tank, int dps, int support)
        {
            this.name = name;
            this.scores = new ScoreByPosition(tank, dps, support);
        }
    }
}
