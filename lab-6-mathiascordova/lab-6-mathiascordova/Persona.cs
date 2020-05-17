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
    class Persona
    {
        private string employeeName;
        private string employeeSurname;
        private string employeeRUT;
        private string employeeCharge;

        public Persona(string name, string surname, string rut)
        {
            employeeName = name;
            employeeSurname = surname;
            employeeRUT = rut;
            
        }

        public void SetCharge(string charge)
        {
            employeeCharge = charge;
        }

        public string GetEmployee()
        {
            return ("Nombre empleado: " + employeeName + " " + employeeSurname + Environment.NewLine + "RUT empleado: " + employeeRUT + Environment.NewLine + "Cargo empleado: " + employeeCharge);
        }
    }
}
