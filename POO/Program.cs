// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Hola Programación orientada a objetos!");
Console.WriteLine("======================================");

Employee employee1 = new SalaryEmployee()
{   Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1814256.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 1012,
    FirstName = "Nataly",
    LastName = "Giraldo",
    BirthDate = new Date(1986, 11, 22),
    HiringDate = new Date(2022, 8, 11),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F,
};

Console.WriteLine(employee1);
Console.WriteLine(employee2);