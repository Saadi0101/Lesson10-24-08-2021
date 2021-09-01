using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Андрей", "Малахов", "Журналист", 1500);
            employee1.GetInfo();

            Employee employee2 = new Employee("Фёдр", "Бандарчук", "Режессёр", 2500);
            employee2.GetInfo();

            Employee employee3 = new Employee("Ольга", "Бузова", "Певица", 5000);
            employee3.GetInfo();

        }
    }
    
    class Employee
    {
        public string name;
        public string lasName;
        public int zp;
        public double nal;
        public double penFon;
        public double chzp;
        public string dol;

        public Employee () { }
        public Employee(string Name, string LastName, string Dol, int ZP)
        {
            name = Name;
            lasName = LastName;
            zp = ZP;
            dol = Dol;
            
        }

        public void GetInfo()
        {
            nal = zp * 13 / 100;
            penFon = zp * 1 / 100;
            chzp = zp - nal - penFon;
            Console.WriteLine($"Имя: {name}\nФамилия: {lasName}\nДолжность: {dol}\nЗ/П: {zp}\nНалог: {nal}\nПенсионный фонд: {penFon}\nЧистая З/П: {chzp}");
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
