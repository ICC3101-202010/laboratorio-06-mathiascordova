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

            Empresa empresa = new Empresa();
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
                    System.Threading.Thread.Sleep(4000);
                    continue;
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
