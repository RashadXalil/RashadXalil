using Rashadxalilovconsoleapp.Interface;

using System;
using System.Collections.Generic;
using System.Text;
using Rashadxalilovconsoleapp.Models;

namespace Rashadxalilovconsoleapp.Service
{
    class HumanManagerService : IhumanResourceManager
    {
        private Department[] _departments;
        public Department[] Departments => _departments;
        public HumanManagerService()
        {
            _departments = new Department[0];
        }
        //Employees

        //Isci yaratmaq ucun method
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department(name, workerlimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
            Console.WriteLine("Department ugurla elave olundu!");

        }
        //Departmentleri list etmek ucun method
        public Department[] ListDepartment() 
        {          
            return _departments;
        }
        // Iscileri list etmek ucun method
        public void ListofEmployee()
        {

        }
        // Department uzerinde deyisiklik etmek ucun method
        public void EditDepartment(string oldname, string newName)
        {
            foreach (Department item in Departments)
            {
                //if (item.Name == oldname)
                //{
                    item.Name = newName;
                    Console.WriteLine("Deyisiklik qeyde alindi!");
                    return;

                //}
            }






        }
        // movcud isci uzerinde deyisiklik etmek ucun method
        public void EditEmployee()
        {
            throw new NotImplementedException();
        }
        //Departmentdeki iscilerin melumatlarini gosteren method
        public void GetDepartment()
        {
            foreach (Department item in _departments)
            {
                Console.WriteLine(item);
            }
        }
        //Movcud iscini silmek ucun method
        public void RemoveEmployee(string depname,string workerno,string workername)
        {
            Department department = null; // icinde axtaris etdiyimiz department
            //department axtarmaq
            foreach (Department item in _departments)
            {
                if (item.Name.ToLower() != depname.ToLower())
                {
                    Console.WriteLine("Bele bir Department yoxdur  !");
                    break;
                  
                }
                else
                {
                    department = item;
                    break;
                }
            }           
            Employee employee = null; 

            if (department != null)
            {
                foreach (Employee item in department.Employees)
                {
                                       
                    if (item.FullName.ToUpper() != workername.ToUpper())
                    {
                        Console.WriteLine("Daxil etdiyiniz Departmentde bu adda isci yoxdur !");
                        break;
                        
                    }
                    else
                    {
                        if (workerno != item.No)
                        {
                            Console.WriteLine("Daxil etdiyiniz iscinin No-su duzgun deyil !");
                            break;
                           
                        }
                        else
                        {
                            employee = item;
                            break;
                        }
                    }

                }
            }
            if (employee!=null)
            {
                int index = Array.IndexOf(department.Employees, employee);
                Array.Clear(department.Employees, index, 1);
                Console.WriteLine("Isci ugurla silindi!");
            }
        }
        //Isci yaratmaq ucun method
        public void AddEmployee(string fullname, Enums position, int salary, int departmentindex)
        {
            Department department = _departments[departmentindex];
            if (department.WorkerLimit > department.Employees.Length)
            {
                if (department.SalaryLimit > salary)
                {
                    Employee employee = new Employee(fullname, position, salary, department);
                    department.AddEmployye(employee);
                    Console.WriteLine("Isci yaradildi");
                    return;
                }
                else
                {
                    Console.WriteLine("salary limiti asmisiniz");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Worker limiti asmisiniz.");
                return;
            }
            

        }
        //Departmentin melumatlarini cap etmek ucun method
        public void InfoDepartment()
        {
           
                foreach (var item in Departments)
                {
                for (int i = 0; i < Departments.Length; i++)
                {
                    if (item.Employees == null)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"Department Name: {item.Name} || Isci sayi: {item.Employees.Length}  || Ortalama maas : {item.CalcSum()}");
                        break;
                    }
                }
                }
            
            
             
            
        }
        //Movcud isci uzerinde deyisiklik etmek ucun method
        public void EditEmployee(string no,double salary,Enums position)
        {
            //string[] positiontype = Enum.GetNames(typeof(Enums));
            //for (int i = 0; i < positiontype.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} - {positiontype[i]}");
            //}
            //string typestr;
            //int typeint;
            //do
            //{
            //    Console.Write("Deyisdirmek istediyiniz positionu secin:");
            //    typestr = Console.ReadLine();


            //}

            //while (!int.TryParse(typestr, out typeint));
            //Enums enums = (Enums)typeint;


            //Console.WriteLine("Yeni position:");
            //int typeint2 = int.Parse(Console.ReadLine());
            // = (Enums)typeint2;
            //Console.WriteLine("Done!");


        }

        
    }
}



