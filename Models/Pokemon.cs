using System;
using System.Collections.Generic;


namespace firstWebApi.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public int height { get; set; }
        public string name { get; set; }
        public List<Form> forms { get; set; }

        public List<Moves> moves { get; set; }

         public List<Abilities> abilities { get; set; }

        public Sprintes sprites { get; set; }

    }

    public class Form{

        public string name { get; set; }
        public string url { get; set; }

    }


    public class Moves {
        public Move Move { get; set; }

    }

    public class Move {
        public string name { get; set; }
        public string url { get; set; }
    }


    public class Sprintes{

        public string front_default { get; set; }

    }

    public class Abilities {
        public Abilitiy ability { get; set; }
    } 

    public class Abilitiy {
        public string name { get; set; }
    }

}