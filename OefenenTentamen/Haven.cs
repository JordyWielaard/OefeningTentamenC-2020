using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OefenenTentamen
{
    public class Haven<T> where T : Schip
    {
        public List<T> Schepen;
        public delegate void Waarschuwing(object sender, OmkerenHandler e);
        public event Waarschuwing Omkeren;

        public string Name { get; set; }

        public Haven(string name)
        {
            Schepen = new List<T>();
            Name = name;
        }

        public void AddSchip(T schip)
        {
            Schepen.Add(schip);
            Omkeren += schip.Omkeren;
        }

        public void RemoveSchip(T schip)
        {
            Schepen.Remove(schip);
        }

        public int AverageSpeedOfSchips()
        {
            //return Schepen.Select(i => i.Speed).Sum() / Schepen.Count;
            //return (from schip in Schepen select schip.Speed).Sum() / Schepen.Count;
            return (Schepen.Where(i => i is CruiseSchip).Select(i => i.Speed)).Sum() / Schepen.Count;
        }

        public void LaatSchepenOmkeren(string waarschuwing)
        {
            Omkeren?.Invoke(this, new OmkerenHandler() { Waarschuwing = waarschuwing});
        }
    }
}
