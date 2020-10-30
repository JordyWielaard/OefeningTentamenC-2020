using System;
using System.Collections.Generic;
using System.Text;

namespace OefenenTentamen
{
    public class CruiseSchip : Schip
    {
        public CruiseSchip(string name, int speed, int personen)
        {
            Name = name;
            Speed = speed;
            Personen = personen;
        }

        public string Name { get; set; }
        public int Speed { get; set; }
        public int Personen { get; set; }
        
        public void Omkeren(object sender, OmkerenHandler e)
        {
            var haven = (Haven<Schip>)sender;
            Console.WriteLine($"CruiseSchip: {Name} Gaat omkeren met code: {e.Waarschuwing} Naar haven: {haven.Name}");
        }
    }
}
