using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            return obj is User user && name == user.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }
    }
}
