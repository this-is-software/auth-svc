namespace UserAPI.Svc
{
    public struct User
    {
        public int Id;
        public string DisplayName;
        public Pronouns Pronouns;
    }

    public struct Pronouns
    {
        public string Subject;
        public string Object;
        public string Possessive;
    }
}