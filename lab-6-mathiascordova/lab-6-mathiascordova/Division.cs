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
    [Serializable]
    class Division
    {
        protected Persona divisionBoss;
        protected string divisionName="Division";

        public virtual void SetBoss(Persona boss)
        {
            divisionBoss = boss;
            divisionBoss.SetCharge("Jefe de Division");
            
        }

        public string GetName()
        {
            return divisionName;
        }

        public virtual string GetBoss()
        {
            return divisionBoss.GetEmployee()+Environment.NewLine + "_________________________________________________"+Environment.NewLine + Environment.NewLine;
        }

        
    }
}
