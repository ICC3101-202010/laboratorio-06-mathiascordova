﻿using System;
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
    class Departamento : Division
    {
        public Departamento()
        {
            this.divisionName = "Departamento";
        }
        public override void SetBoss(Persona boss)
        {
            divisionBoss = boss;
            divisionBoss.SetCharge("Jefe de Departamento");

        }
    }
}
