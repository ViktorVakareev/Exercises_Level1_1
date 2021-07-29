using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_Level1_1
{
    public enum Gender 
    { 
        m, 
        f 
    };
    public class Employee
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }
        public Gender gender;
        public int IdNumber { get; set; }
        public long EmployeeNumber { get; set; }

        public Employee()
        {

        }
        public Employee(string firstName, string familytName, Gender gender, int age, int idNumber, long employeeNumber)
        {
            FirstName = firstName;
            FamilyName = familytName;
            Age = age;
            this.gender = gender;
            IdNumber = idNumber;
            EmployeeNumber = employeeNumber;
        }
        public override string ToString()
        {
            return $"Employee: {FirstName} {FamilyName} is {Age} years old, gender: '{gender}', " +
                $"ID: {IdNumber} and Employee ID : {EmployeeNumber}\n";
        }

    }

}
