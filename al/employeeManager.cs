using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEmployee
{
    internal class employeeManager 
    {
        public static ArrayList arrayList = new ArrayList();
        public employeeManager()
        {
            arrayList.Add(new Employee(1, 18, "Thanh", 20000));
            arrayList.Add(new Employee(2, 18, "Tu", 22000));
            arrayList.Add(new Employee(3, 18, "Thang", 29000));
        }
        public static void AddEmployee()
        {
            Console.WriteLine("Nhap id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap name");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap age");
            int age  = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap salary");
            int salary = int.Parse(Console.ReadLine());
            Employee employee = new Employee(id,age, name, salary);
            arrayList.Add(employee);
        }
        public static void getAll()
        {
            foreach(Employee emp in arrayList)
            {
                Console.WriteLine(" " + emp);
            }
        }
        public static void delete(int id) 
        {

            try
            {
                foreach (Employee emp in arrayList)
                {
                    if (emp.id == id)
                    {
                        arrayList.Remove(emp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("But is alreadly to delete .... . Done :");
            }
        }
        public static void Update(int id)
        {
            foreach (Employee emp in arrayList)
            {
                if (emp.id == id)
                {
                    Console.WriteLine("Nhap name");
                    string names = Console.ReadLine();
                    emp.name = names;
                    Console.WriteLine("Nhap age");
                    int ages = int.Parse(Console.ReadLine());
                    emp.age = ages;
                    Console.WriteLine("Nhap salary");
                    int salaris = int.Parse(Console.ReadLine());
                    emp.salary = salaris;
                }
            }
        }
        public static void menu()
        {
            Console.WriteLine("1. Get All \n2. Add \n3. Update \n4. Delete");
        }
        public static void Main(string[] cmd)
        {
            employeeManager e = new employeeManager();
            bool flag = true;
            menu();
            while (flag)
            {
                Console.WriteLine("Chon :");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        getAll();
                        menu();
                        break;
                    case 2:
                        AddEmployee();
                        menu();
                        break;
                    case 3:
                        Console.WriteLine("Nhap employee id can update :");
                        int id = int.Parse(Console.ReadLine());
                        Update(id);
                        menu();
                        break;
                    case 4:
                        Console.WriteLine("Nhap employee id can xoa :");
                        int idd = int.Parse(Console.ReadLine());
                        delete(idd);
                        menu();
                        break;
                    case 0:
                        flag = false;
                        break;
                            
                                        


                }
            }
        }
    }
   
}
