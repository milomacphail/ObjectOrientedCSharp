 using System;

namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien ();
        }
    }
        public class baseProperties 
        {
            public baseProperties () {
            }
            public bool moves { get; set;}
            public string color { get; set;}
        }

    public class Human : baseProperties
    {
        public Human () {
        }
        public string name { get; set; }
    }

    public class Man : Human
    {
        public Man () {
        }
    }

    public class Woman : Human
    {
        public Woman () {

        }

    }
    public class Kart : baseProperties
    {
        public Kart () {

        }
        public string model { get; set;}
    }
    
    public class Alien : baseProperties
    {
    public Alien () {

    }
            public string planet { get; set;}
    }
}
