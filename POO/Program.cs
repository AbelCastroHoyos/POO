// See https://aka.ms/new-console-template for more information
using POO;
using System.Collections;
using System.Runtime.InteropServices;

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

Employee employee3 = new HourlyEmployee()
{
    Id = 1014,
    FirstName = "Abel",
    LastName = "Castro",
    BirthDate = new Date(1986, 11, 22),
    HiringDate = new Date(2022, 8, 11),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 12356.56M
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 1016,
    FirstName = "Matthias",
    LastName = "Castro",
    BirthDate = new Date(2010, 2, 19),
    HiringDate = new Date(2010, 2, 19),
    IsActive = true,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F,
    Base = 860678.45M
};

//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
  };

decimal payroll = 0;
foreach (Employee employee in employees) {
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine($"\t                      ==================");
Console.WriteLine($"\tTotal                 {$"{payroll:C2}",18}");


Invoice invoice = new Invoice()
{
    Id = 1,
    Description = "Camiseta T-20",
    Price = 12500M,
    Quantity = 2
};
Console.WriteLine(invoice);