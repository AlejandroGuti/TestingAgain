using TestingAgain;

Console.WriteLine("Hello, World!");
Console.WriteLine("=================");

Employee employee1 = new SalaryEmployee() 
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
    };
Employee employee2 = new CommissionEmployee()
{
    Id = 10,
    FirstName = "Sandra2",
    LastName = "Morales2",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 2000M,
    CommissionPercentaje = 0.03F
};
Console.WriteLine(employee1);
Console.WriteLine(employee2);