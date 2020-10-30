using System;

namespace OefenenTentamen
{
    class Program
    {
        static void Main(string[] args)
        {
            CruiseSchip c1 = new CruiseSchip("Herman", 190, 12);
            CruiseSchip c2 = new CruiseSchip("NoordAmericaLijn", 80, 123);
            VrachtSchip v1 = new VrachtSchip("HeelVeelLading", 120, 42);

            Haven<Schip> h = new Haven<Schip>("Dover");
            Haven<Schip> h1 = new Haven<Schip>("Ergens");

            h.AddSchip(v1);
            h1.AddSchip(c2);
            h.AddSchip(c1);

            h.LaatSchepenOmkeren("CODE1234");
            h1.LaatSchepenOmkeren("CODE1234");
        }
    }
}
