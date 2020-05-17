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
    class Bloque : Division
    {
        private List<Persona> blockEmployees;
        public Bloque()
        {
            this.divisionName = "Bloque";
        }
        public override void SetBoss(Persona boss)
        {
            divisionBoss = boss;
            divisionBoss.SetCharge("Jefe de Bloque");

        }
        public void SetEmployees(List<Persona>employees)
        {
            blockEmployees = employees;
        }

        public List<Persona> GetEmployees()
        {
            return blockEmployees;
        }

        public override string GetBoss()
        {
            return (divisionBoss.GetEmployee() + Environment.NewLine + Environment.NewLine+ blockEmployees[0].GetEmployee() + Environment.NewLine + Environment.NewLine+ blockEmployees[1].GetEmployee()+ Environment.NewLine+"_________________________________________________" + Environment.NewLine + Environment.NewLine);
        }
    }
}
