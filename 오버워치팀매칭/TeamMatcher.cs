using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 오버워치팀매칭
{
    public class TeamMatcher
    {
        public List<Result> match(Dictionary<string, ScoreByPosition> settings, List<User> users, int maximumPointDifference)
        {
            if (users == null || users.Count != 12)
            {
                return null;
            }

            HashSet<Result> matchResults = new HashSet<Result>(new ResultComparator());

            bool[] used = new bool[12];
            for (int i1 = 0; i1 < 12; i1++)
            {
                if (used[i1])
                {
                    continue;
                }
                used[i1] = true;
                for (int i2 = i1 + 1; i2 < 12; i2++)
                {
                    if (used[i2])
                    {
                        continue;
                    }
                    used[i2] = true;
                    for (int i3 = 0; i3 < 12; i3++)
                    {
                        if (used[i3])
                        {
                            continue;
                        }
                        used[i3] = true;
                        for (int i4 = i3 + 1; i4 < 12; i4++)
                        {
                            if (used[i4])
                            {
                                continue;
                            }
                            used[i4] = true;
                            for (int i5 = 0; i5 < 12; i5++)
                            {
                                if (used[i5])
                                {
                                    continue;
                                }
                                used[i5] = true;
                                for (int i6 = i5 + 1; i6 < 12; i6++)
                                {
                                    if (used[i6])
                                    {
                                        continue;
                                    }
                                    used[i6] = true;
                                    for (int i7 = 0; i7 < 12; i7++)
                                    {
                                        if (used[i7])
                                        {
                                            continue;
                                        }
                                        used[i7] = true;
                                        for (int i8 = i7 + 1; i8 < 12; i8++)
                                        {
                                            if (used[i8])
                                            {
                                                continue;
                                            }
                                            used[i8] = true;
                                            for (int i9 = 0; i9 < 12; i9++)
                                            {
                                                if (used[i9])
                                                {
                                                    continue;
                                                }
                                                used[i9] = true;
                                                for (int i10 = i9 + 1; i10 < 12; i10++)
                                                {
                                                    if (used[i10])
                                                    {
                                                        continue;
                                                    }
                                                    used[i10] = true;
                                                    for (int i11 = 0; i11 < 12; i11++)
                                                    {
                                                        if (used[i11])
                                                        {
                                                            continue;
                                                        }
                                                        used[i11] = true;
                                                        for (int i12 = i11 + 1; i12 < 12; i12++)
                                                        {
                                                            if (used[i12])
                                                            {
                                                                continue;
                                                            }
                                                            used[i12] = true;
                                                            evaluateAndAddResult(users, matchResults, settings, maximumPointDifference, i1, i2, i3 ,i4, i5, i6, i7, i8, i9, i10, i11, i12);
                                                            used[i12] = false;
                                                        }
                                                        used[i11] = false;
                                                    }
                                                    used[i10] = false;
                                                }
                                                used[i9] = false;
                                            }
                                            used[i8] = false;
                                        }
                                        used[i7] = false;
                                    }
                                    used[i6] = false;
                                }
                                used[i5] = false;
                            }
                            used[i4] = false;
                        }
                        used[i3] = false;
                    }
                    used[i2] = false;
                }
                used[i1] = false;
            }

            return matchResults.ToList().OrderBy(r => Math.Abs(r.aTeamPoint - r.bTeamPoint)).ThenByDescending(r => r.aTeamAverage + r.bTeamAverage).ToList();
        }

        private void evaluateAndAddResult(List<User> users, HashSet<Result> results, Dictionary<string, ScoreByPosition> settings, int maximumPointDifference, int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12)
        {
            int aTeamPoint = 
                settings[getTier(users[i1].scores.tank)].tank +
                settings[getTier(users[i2].scores.tank)].tank +
                settings[getTier(users[i3].scores.dps)].dps +
                settings[getTier(users[i4].scores.dps)].dps +
                settings[getTier(users[i5].scores.support)].support +
                settings[getTier(users[i6].scores.support)].support;
            int bTeamPoint = 
                settings[getTier(users[i7].scores.tank)].tank +
                settings[getTier(users[i8].scores.tank)].tank +
                settings[getTier(users[i9].scores.dps)].dps +
                settings[getTier(users[i10].scores.dps)].dps +
                settings[getTier(users[i11].scores.support)].support +
                settings[getTier(users[i12].scores.support)].support;

            if (Math.Abs(aTeamPoint - bTeamPoint) < maximumPointDifference)
            {
                Result currentResult = new Result(
                    new List<User> { users[i1], users[i2], users[i3], users[i4], users[i5], users[i6] },
                    new List<User> { users[i7], users[i8], users[i9], users[i10], users[i11], users[i12] },
                    aTeamPoint, bTeamPoint);

                results.Add(currentResult);
            }
        }

        private string getTier(int score)
        {
            if (0 <= score  && score < 1250)
            {
                return "bronze1";
            }
            else if (1250 <= score && score < 1500)
            {
                return "bronze2";
            }
            else if (1500 <= score && score < 1750)
            {
                return "silver1";
            }
            else if (1750 <= score && score < 2000)
            {
                return "silver2";
            }
            else if (2000 <= score && score < 2250)
            {
                return "gold1";
            }
            else if (2250 <= score && score < 2500)
            {
                return "gold2";
            }
            else if (2500 <= score && score < 2750)
            {
                return "platinum1";
            }
            else if (2750 <= score && score < 3000)
            {
                return "platinum2";
            }
            else if (3000 <= score && score < 3250)
            {
                return "diamond1";
            }
            else if (3250 <= score && score < 3500)
            {
                return "diamond2";
            }
            else if (3500 <= score && score < 3750)
            {
                return "master1";
            }
            else if (3750 <= score && score < 4000)
            {
                return "master2";
            }
            else if (4000 <= score && score < 4250)
            {
                return "grandmaster1";
            }
            else if (4250 <= score && score <= 5000)
            {
                return "grandmaster2";
            } else
            {
                return null;
            }
        }
    }
}
