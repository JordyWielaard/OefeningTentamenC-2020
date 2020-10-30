using System;
using System.Collections.Generic;
using System.Text;

namespace OefenenTentamen
{
    public interface Schip
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public void Omkeren(object sender, OmkerenHandler e);
    }
}
