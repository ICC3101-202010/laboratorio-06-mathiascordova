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
    class Program
    {

        
        static void Main(string[] args)
        {
            void Save(Empresa company)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, company);
                stream.Close();
            }

            Empresa Load()
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("empresa.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                Empresa company = (Empresa)formatter.Deserialize(stream);
                stream.Close();
                return company;
            }
            List<Persona> allEmployees = new List<Persona>() {new Persona("Mathias","Cordova","20.339.651-1"), new Persona("Lionel","Messi","15.098.156-2"), new Persona("Andres", "Howard", "16.876.345-3"), new Persona("Carlos", "Diaz", "18.986.320-8"), new Persona("Alvaro", "Hernandez", "12.345.678-9"), new Persona("Jaime", "Cisternas", "9.123.456-0"), new Persona("Roger", "Federer", "9.420.696-9"), new Persona("Naruto", "Uzumaki", "19.637.505-8"), new Persona("Jarad", "Higgins", "19.999.999-9") };
            Empresa empresa = new Empresa();
            Random random = new Random();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("INFO EMPRESAS" + Environment.NewLine + Environment.NewLine + "[1] Crear empresa desde cero" + Environment.NewLine + "[2] Ver datos de empresa existente" + Environment.NewLine + "[X] Cerrar programa");
                Console.Write("==>  ");
                string choice = Console.ReadLine();

                if (choice == "x" || choice == "X")
                {
                    Console.Clear();
                    Console.WriteLine("Hasta la vista baby");
                    System.Threading.Thread.Sleep(1000);
                    Save(empresa);
                    break;
                }
                

                else if (choice == "1")
                {
                    Console.Clear();
                    Console.Write("Ingrese el nombre de la empresa: ");
                    empresa.SetName(Console.ReadLine());
                    Console.Write("Ingrese el RUT de la empresa: ");
                    empresa.SetRUT(Console.ReadLine());
                    List <Division> divisions = new List<Division>();

                    Area area = new Area();
                    int i = random.Next(allEmployees.Count());
                    area.SetBoss(allEmployees[i]);
                    allEmployees.RemoveAt(i);
                    divisions.Add(area);

                    Departamento depto = new Departamento();
                    i = random.Next(allEmployees.Count());
                    depto.SetBoss(allEmployees[i]);
                    allEmployees.RemoveAt(i);
                    divisions.Add(depto);

                    Seccion secc = new Seccion();
                    i = random.Next(allEmployees.Count());
                    secc.SetBoss(allEmployees[i]);
                    allEmployees.RemoveAt(i);
                    divisions.Add(secc);

                    Bloque bloque1 = new Bloque();
                    List<Persona> emp = new List<Persona>();
                    i = random.Next(allEmployees.Count());
                    bloque1.SetBoss(allEmployees[i]);
                    allEmployees.RemoveAt(i);
                    int a = random.Next(allEmployees.Count());
                    allEmployees[a].SetCharge("Empleado de bloque");
                    emp.Add(allEmployees[a]);
                    allEmployees.RemoveAt(a);
                    a = random.Next(allEmployees.Count());
                    allEmployees[a].SetCharge("Empleado de bloque");
                    emp.Add(allEmployees[a]);
                    allEmployees.RemoveAt(a);
                    bloque1.SetEmployees(emp);
                    divisions.Add(bloque1);

                    Bloque bloque2 = new Bloque();
                    List<Persona> emp1 = new List<Persona>();
                    i = random.Next(allEmployees.Count());
                    bloque2.SetBoss(allEmployees[i]);
                    allEmployees.RemoveAt(i);
                    a = random.Next(allEmployees.Count());
                    allEmployees[a].SetCharge("Empleado de bloque");
                    emp1.Add(allEmployees[a]);
                    allEmployees.RemoveAt(a);
                    a = random.Next(allEmployees.Count());
                    allEmployees[a].SetCharge("Empleado de bloque");
                    emp1.Add(allEmployees[a]);
                    allEmployees.RemoveAt(a);
                    bloque2.SetEmployees(emp1);
                    divisions.Add(bloque2);


                    empresa.SetDivisions(divisions);
                    Save(empresa);
                    Console.WriteLine("Se creo la empresa con exito");
                    System.Threading.Thread.Sleep(1000);
                    continue;
                }


                else if (choice == "2")
                {
                    empresa = Load();
                    Console.Clear();
                    Console.WriteLine("Nombre de empresa: "+empresa.GetName());
                    Console.WriteLine("RUT de empresa: "+empresa.GetRUT());
                    Console.WriteLine("");
                    List<Division> companyDiv = empresa.GetDivisions();
                    for (int i = 0; i < companyDiv.Count(); i++)
                    {
                        Console.WriteLine(companyDiv[i].GetName() + Environment.NewLine + companyDiv[i].GetBoss());
                    }

                    break;
                }


                else
                {
                    Console.Clear();
                    Console.WriteLine("Input invalido");
                    System.Threading.Thread.Sleep(1000);
                    continue;

                }
            }

        }
    }
}
