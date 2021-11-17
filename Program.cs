using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexion
{

    class ReflectedClass
    {
        private Int32 _id;
        private String Name { get; set; }

        private int id { get; set; }

        public ReflectedClass()
        {
            _id = 0;
            Name = String.Empty;
        }

        private void DoSomething()
        {
            Console.WriteLine("I am doing something ...");
        }

    }

    static class Program
    {
        static void Main(string[] args)
        {
            ReflectedClass reflectedClass = new ReflectedClass();
            reflectedClass.GetAllProperties();
            Console.WriteLine( "-------");
            reflectedClass.GetAllMethods();
            Console.WriteLine("-------");
            reflectedClass.GetAllFields();


            Console.ReadLine();
        }

        static void GetAllProperties(this object objet)
        {
            PropertyInfo[] properties = objet.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var p in properties)
            {
                Console.WriteLine($"{p.Name} ({p.PropertyType}) ");
            }
        }

        static void GetAllFields(this object objet)
        {
            var fields = objet.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var p in fields)
            {
                Console.WriteLine($"{p.Name} ({p.DeclaringType}) ");
            }
        }

        static void GetAllMethods(this object objet)
        {
            var methods = objet.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var p in methods)
            {
                Console.WriteLine($"{p.Name} ({p.DeclaringType}) ");
            }
        }

    }

    public static class ExtentionObjet{



    }
}
