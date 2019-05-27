using System.Collections.Generic;

namespace SquadGoals.Api
{
    public struct User
    {
        public int id;
        public string displayName;
        public Pronouns pronouns;
    }

    public struct Pronouns
    {
        public string Subject;
        public string Object;
        public string Possessive;
    }
}