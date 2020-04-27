namespace Hello_world_json
{
    //public class Class1
    //{
    //public class Query
    //{
    //    [GraphQLMetadata("jedis")]
    //    public IEnumerable<Jedi> GetJedis()
    //    {
    //        return Jedi.GetJedis();
    //    }
    //    [GraphQLMetadata("jedi")]
    //    public Jedi GetJedi(int id)
    //    {
    //        return Jedi.GetJedis().SingleOrDefault(j => j.Id == id);
    //    }

    //    //[GraphQLMetadata("hello")]
    //    //public string GetHello()
    //    //{
    //    //    return "Hello Query class";
    //    //}
    //}

    //public class Jedi
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Side { get; set; }

    //            public static IEnumerable<Jedi> GetJedis()
    //            {
    //                return new List<Jedi>() {
    //        new Jedi(){  Id=1,Name ="Luke", Side="Light"},
    //        new Jedi(){ Id=2, Name ="Yoda", Side="Light"},
    //        new Jedi(){Id=3, Name ="Darth Vader", Side="Dark"}
    //         };
    //    }

    //}
    //public class Droid
    //{
    //    public string Id { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Query
    //{
    //    [GraphQLMetadata("droid")]
    //    public Droid GetDroid()
    //    {
    //        return  new Droid { Id = "123", Name = "R2-D2" };
    //    }
    //}
    // }

     class human2
    {
        private int age;
        private string name;
        private string lastname;

        public void addage()
        {
            age++;
        }

        public string getName()
        {
            return name + "" + lastname;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }
    }
}