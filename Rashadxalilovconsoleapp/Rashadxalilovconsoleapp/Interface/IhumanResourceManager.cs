using System;
using System.Collections.Generic;
using System.Text;

using Rashadxalilovconsoleapp.Models;
namespace Rashadxalilovconsoleapp.Interface
{
    interface IhumanResourceManager 
    {
        // Department arrayi
        Department[] Departments { get; }
        //Department Add etmek ucun istifade etdiyimiz method
        public void AddDepartment(string name,int workerlimit,double salarylimit);
        // Departmentleri list edir
        public Department[] ListDepartment();
        //Departmentlerin uzerinde deyisiklik etmek ucun method
        public void EditDepartment(string oldname, string newname);
        // yeni isci yaratmaq ucun method
        public void AddEmployee(string fullname,Enums position,int salary,int departmentindex);
        //Movcud iscini silmek ucun ,method
        public void RemoveEmployee(string depname,string workerno,string workername);
        //Muvcud isci ucerinde deyisiklik etmek ucun method
        public void EditEmployee(string no,double salary,Enums position);          
    }
}
