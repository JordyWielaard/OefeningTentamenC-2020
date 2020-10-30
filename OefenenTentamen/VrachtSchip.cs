using System;
using System.Collections.Generic;
using System.Text;

namespace OefenenTentamen
{
    public class VrachtSchip : Schip
    {
        public VrachtSchip(string name, int speed, int containers)
        {
            Name = name;
            Speed = speed;
            Containers = containers;
        }

        public string Name { get; set; }
        public int Speed { get; set; }
        public int Containers { get; set; }

        public void Omkeren(object sender, OmkerenHandler e)
        {
            var haven = (Haven<Schip>)sender;
            Console.WriteLine($"VrachtSchip: {Name} Gaat omkeren met code: {e.Waarschuwing} Naar haven: {haven.Name}");
        }
    }
}
