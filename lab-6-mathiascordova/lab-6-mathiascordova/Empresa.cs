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
    class Empresa
    {
        private string companyName;
        private string companyRUT;
        private List<Division> companyDivisions;

        public void SetName(string name)
        {
            companyName = name;
        }
        public void SetRUT(string rut)
        {
            companyRUT = rut;
        }

        public string GetName()
        {
            return companyName;
        }

        public string GetRUT()
        {
            return companyRUT;
        }

        public void SetDivisions(List<Division> divisions)
        {
            companyDivisions = divisions;
        }

        public List<Division> GetDivisions()
        {
            return companyDivisions;
        }
    }
}
