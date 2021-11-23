﻿using Rashadxalilovconsoleapp.Models;
using Rashadxalilovconsoleapp.Service;
using System;
namespace Rashadxalilovconsoleapp
{
    class Program
    {
        private static int salary;
        static void Main(string[] args)
        {
            HumanManagerService programcs = new HumanManagerService();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            tryagain:
            Console.WriteLine("                                                -Employee Information system-");
            Console.WriteLine("         ***************************************************************************************************");
            Console.WriteLine("1.List of Departaments\n2.Create a Departament\n3.To make change on Departament\n4.List of Workers\n5.List Workers of Departament\n6.Create new Worker\n7.To make change about Worker\n8.Delete Worker\n9.Exit");
            Console.Write("\nYerine Yetirmek istediyiniz emeliyyati daxil edin : ");
            
            int enter = Convert.ToInt32(Console.ReadLine());
            switch (enter)
            {
                #region case1

               
                case 1:
                    programcs.InfoDepartment();
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise = Console.ReadLine();                
                    if (choise.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }
                #endregion 
                #region case2

              
                case 2:
                    AddDepartment(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise1 = Console.ReadLine();
                    if (choise1.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }
                #endregion 
                #region case3

              
                case 3:
                    EditDepartment(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise2 = Console.ReadLine();
                    if (choise2.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }
                #endregion
                #region case4
                case 4:
                    ShowEmployees(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise0 = Console.ReadLine();
                    if (choise0.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }

                                 
                #endregion
                #region case5

               
                case 5:
                    programcs.ListDepartment();
                    Console.Write("Enter Department Name: ");
                    string dprtname = Console.ReadLine();

                    foreach (var item in programcs.ListDepartment())
                    {
                        if (item.Name.ToUpper() == dprtname.ToUpper())
                        {

                            foreach (var item1 in item.Employees)
                            {

                                if (item1 != null)
                                {
                                    Console.WriteLine($"Full Name: {item1.FullName} \nNo: {item1.No} \nDepartment: {item1.DepartmentName} \nPosition: {item1.Position} \nSalary: {item1.Salary}");
                                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                }
                            }
                        }

                    }
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise7 = Console.ReadLine();
                    if (choise7 == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }
                #endregion
                #region case6 


                case 6:
                    AddEmployee(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise4 = Console.ReadLine();
                    if (choise4.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }
                #endregion
                #region case7
                case 7:
                    EditEmployee(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise21 = Console.ReadLine();
                    if (choise21.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }

                #endregion
                #region case8
                case 8:
                    RemoveEmoployee(ref programcs);
                    Console.Write("Davam etmek isteyirsiniz ? y/n : ");
                    string choise211 = Console.ReadLine();
                    if (choise211.ToLower() == "y")
                    {
                        goto tryagain;
                    }
                    else
                    {
                        Console.WriteLine("Sistemden ugurla cixildi !");
                        Console.WriteLine(DateTime.Now);
                        break;
                    }                   
                #endregion
                #region case9

               
                case 9:
                    Console.WriteLine("Sistemden ugurla cixildi !");
                    Console.WriteLine(DateTime.Now);
                    return;
                default:

                    Console.WriteLine("Dogru emeliyyat secdiyinizden emin olun:");
                    Console.Write("Yeniden cehd edin :");
                    goto tryagain;
                    #endregion

            }
        }
        //Department elave etmek ucun method
        static void AddDepartment(ref HumanManagerService programcs)
        {
            Console.Write("Departmentin adini daxil edin :");
            string name = Console.ReadLine();
        tryagainsalarylimit:
            Console.Write("Workerlimiti daxil edin :");
            int workerlimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maas limiti:");
            double salarylimit = Convert.ToDouble(Console.ReadLine());
            if (salarylimit > 250 && workerlimit >= 1)
            {
                programcs.AddDepartment(name, workerlimit, salarylimit);
                Console.WriteLine($"*******************\nDepartament Name:{name} \nDepartamentdeki Isci Limiti:{workerlimit} \nMaas Limit: {salarylimit}\n**************");
            }
            else
            {
                Console.WriteLine("Minimum emek haqqi 250 AZN olmalidir \n Minimum Isci sayi 1 olmalidir \n");
                Console.WriteLine("Yeniden cehd edin :");
                goto tryagainsalarylimit;
            }

        }
        //Department ustunde deyisiklik etmek ucun method
        static void EditDepartment(ref HumanManagerService programcs)
        {
        tryagain1:
            Console.Write("Deyisiklik etmek Departmenitn adini daxil edin :");
            string oldname = Console.ReadLine();
            Console.Write("Departmenin adini daxil edin :");
            string newname = Console.ReadLine();

            foreach (var item in programcs.Departments)
            {
                if (oldname == item.Name)
                {
                    Console.WriteLine("Department Tapildi!");
                    programcs.EditDepartment(oldname, newname);
                    foreach (var item2 in item.Employees)
                    {
                        item2.No = item2.No.Replace(item2.No.Substring(0, 2), newname.ToUpper().Substring(0, 2));
                        item2.DepartmentName = newname;
                    }
                }
                else if (newname == oldname)
                {
                    Console.WriteLine("Daxil etdiyiniz adda department movcud deyil !");

                    goto tryagain1;
                }
                else if (newname == item.Name)
                {
                    Console.WriteLine("Daxil etdiyiniz yeni ad Departmentin movcud adi ile eynidir !");
                    goto tryagain1;
                }
            }

        }
        //isci yaratmaq ucun method
        static void AddEmployee(ref HumanManagerService programcs)
        {
            Console.Write("Ad Soyad:");
            string fullname = Console.ReadLine();

            for (int j = 0; j < programcs.Departments.Length; j++)
            {
                Console.WriteLine($"{j + 1} - {programcs.Departments[j].Name}");
            }
            int dprtInt = int.Parse(Console.ReadLine());
            string[] positiontype = Enum.GetNames(typeof(Enums));
            for (int i = 0; i < positiontype.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {positiontype[i]}");
            }
            string typestr;
            int typeint;
            Console.WriteLine("Position:");
            typestr = Console.ReadLine();
            while (!int.TryParse(typestr, out typeint) || typeint < 1 || typeint > positiontype.Length) 
            { 
                    Console.WriteLine("Yeniden cehd et: ");
                typestr = Console.ReadLine();

            }
            Enums enums = (Enums)typeint;


        tryagain:
            Console.WriteLine("Maas : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (salary <= 250)
            {
                Console.WriteLine("Maas minimum 250 AZN olmalidir.");
                goto tryagain;
            }
 
            programcs.AddEmployee(fullname, enums, salary, (dprtInt - 1));
            
            
           





        }
        //Isci uzerinde deyisiklik etmek ucun method
        static void EditEmployee(ref HumanManagerService programcs)
        {
            Console.WriteLine("Iscinin No-sunu daxil edin : ");
            string no = Console.ReadLine();
            foreach (var item in programcs.Departments)
            {
                foreach (var item1 in item.Employees)
                {
                    if (no.ToUpper() == item1.No.ToUpper())
                    {
                        Console.WriteLine("Isci tapildi!");
                        Console.WriteLine($"Full Name: {item1.FullName} \nPosition: {item1.Position} \nSalary: {item1.Salary} \n* * * * * * * * * * * * * * * * * * *");

                        // Positions
                        string[] positiontype = Enum.GetNames(typeof(Enums));
                        for (int i = 0; i < positiontype.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} - {positiontype[i]}");
                        }

                        string typestr;
                        int typeint;
                        Console.Write("Position:");
                        typestr = Console.ReadLine();
                        while (!int.TryParse(typestr, out typeint) || typeint < 1 || typeint > positiontype.Length)
                        {
                            Console.WriteLine("Tekrar cehd edin: ");
                            typestr = Console.ReadLine();

                        }
                        Enums enums = (Enums)typeint;
                        item1.Position = enums;
                        Console.WriteLine("Position Changed!");

                        Console.Write("Enter new Salary:");
                        double newsalary = int.Parse(Console.ReadLine());
                        foreach (var item3 in programcs.Departments)
                        {
                            foreach (var item4 in item.Employees)
                            {
                                if (salary >= 250 && salary < item.SalaryLimit)
                                {
                                    item1.Salary = newsalary;
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine("Salary is out of Range!");
                                    return;
                                }

                            }
                        }
                        return;
                    }
                }
            }
        }
        // iscilerin siyahisini cixardan method
        static void ShowEmployees(ref HumanManagerService programcs)
        {

            foreach (var item in programcs.Departments)
            {
                
                foreach (var item1 in item.Employees)
                {
                    
                    if (item1 != null)
                    {
                        Console.WriteLine($"NO: {item1.No} \nAd Soyad: {item1.FullName} \nPosition: {item1.Position} \nSalary: {item1.Salary}");

                    }
                }
            }

        }
        //Movcud iscini silmek ucun method
        static void RemoveEmoployee(ref HumanManagerService programcs)
        {
            Console.Write("Silinecek iscinin Departmentini daxil edin :");
            string depname = Console.ReadLine();
            Console.Write("silinecek iscinin adini daxil edin :");
            string workername = Console.ReadLine();
            Console.Write("Silinecek iscinin no daxil edin :");
            string workerno = Console.ReadLine();
            programcs.RemoveEmployee(depname, workerno, workername);
                
        }
    }
}
