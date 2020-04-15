using System;

namespace ShallowandDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Firat";
            emp1.Department = "Yazılım Geliştirme";
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Zeki";
            emp2.Department = "İK";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        //shallow copy and deep copy different
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

}
