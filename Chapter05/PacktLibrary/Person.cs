using System;

namespace Packt.Shared
{

    public class Person
    {
        public EventHandler Shout;
        public int AngerLevel;

        public Person(string name)
        {
            Name = name;
        }

        public object Name { get; set; }

        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
