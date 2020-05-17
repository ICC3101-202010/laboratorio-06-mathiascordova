using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_6_mathiascordova
{
    class Area : Division
    {
        public Area()
        {
            this.divisionName = "Area";
        }
        public override void SetBoss(Persona boss)
        {
            divisionBoss = boss;
            divisionBoss.SetCharge("Jefe de Area");
        }
        
    }
}
