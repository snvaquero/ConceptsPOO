// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("==============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 3),
    HiringDate = new Date(2022,1,15),
    IsActive = true,
    Salary = 1815453.45M
};
Console.WriteLine(employee1);



