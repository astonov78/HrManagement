﻿using Infrastructure;
using Domain.Models;

var it = new Department() { Id = 1, Name = "IT" };
var hr = new Department() { Id = 2, Name = "HR" };
var finance = new Department() { Id = 3, Name = "Finance" };

var role1 = new Role(){ Id = 1, Name = "Admin" };
var role2 = new Role(){ Id = 2, Name = "User" };
var role3 = new Role(){ Id = 3, Name = "Guest" };

var listofEmp = new List<Employee>();

var emp1 =new Employee()
{ 
    Id = 1, 
    FirstName = "John", 
    LastName = "Doe", 
    Department = it, 
    Address = "123 Main St", 
    Phone = "555-555-5555",
    BirthDate = new DateTime(1980, 1, 1),
    Experiences =  new List<Experience>()
    {
        new Experience(){
            Id = 1,
            Company = "ABC",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        },
        new Experience(){
            Id = 1,
            Company = "ABCd",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        }
    },
    Roles = new List<Role>(){role1,role2}
};

listofEmp.Add(emp1);


var emp2 =new Employee()
{ 
    Id = 1, 
    FirstName = "Jahonzeb", 
    LastName = "Jahongizoda", 
    Department = finance, 
    Address = "123 Main St", 
    Phone = "555-555-5555",
    BirthDate = new DateTime(1980, 1, 1),
    Experiences =  new List<Experience>()
    {
        new Experience(){
            Id = 1,
            Company = "ABC",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1 
        },
        new Experience(){
            Id = 1,
            Company = "ABCd",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        }
    },
    Roles = new List<Role>(){role2,role3}
};

listofEmp.Add(emp2);

var emp3 =new Employee()
{ 
    Id = 1, 
    FirstName = "Siyovush", 
    LastName = "Astonzoda", 
    Department = finance, 
    Address = "123 Main St", 
    Phone = "555-555-5555",
    BirthDate = new DateTime(2005, 2, 23),
    Experiences =  new List<Experience>()
    {
        new Experience(){
            Id = 1,
            Company = "ABC",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        },
        new Experience(){
            Id = 1,
            Company = "ABCd",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        }
    },
    Roles = new List<Role>(){role2,role3}
};

listofEmp.Add(emp3);

var emp4 =new Employee()
{ 
    Id = 1, 
    FirstName = "Jahonzeb", 
    LastName = "Jahongizoda", 
    Department = finance, 
    Address = "123 Main St", 
    Phone = "555-555-5555",
    BirthDate = new DateTime(1980, 1, 1),
    Experiences =  new List<Experience>()
    {
        new Experience(){
            Id = 1,
            Company = "ABC",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        },
        new Experience(){
            Id = 1,
            Company = "ABCd",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        }
    },
    Roles = new List<Role>(){role2,role3}
};

listofEmp.Add(emp4);

var emp5 =new Employee()
{ 
    Id = 1, 
    FirstName = "Jahonzeb", 
    LastName = "Jahongizoda", 
    Department = finance, 
    Address = "123 Main St", 
    Phone = "555-555-5555",
    BirthDate = new DateTime(1980, 1, 1),
    Experiences =  new List<Experience>()
    {
        new Experience(){
            Id = 1,
            Company = "ABC",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        },
        new Experience(){
            Id = 1,
            Company = "ABCd",
            Name = "Developer",
            Description = "As a programmer",
            EmployeeId = 1
        }
    },
    Roles = new List<Role>(){role2,role3}
};

listofEmp.Add(emp5);

foreach (var emp in listofEmp)
{
    Console.WriteLine(new string('*', 50));
    Console.WriteLine($"{emp.FirstName} {emp.LastName}");
    Console.WriteLine($"{emp.Department.Name}");
    Console.Write("Experiences: ");
    foreach (var exp in emp.Experiences)
    {
        Console.Write($"{exp.Name},");
    }
    Console.WriteLine();
    Console.Write("Roles: ");
    foreach (var role in emp.Roles)
    {
        Console.Write($"{role.Name},");
    }
    Console.WriteLine();
}