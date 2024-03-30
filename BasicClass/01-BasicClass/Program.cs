// See https://aka.ms/new-console-template for more information
using BasicClass;

Console.WriteLine("Hello, World!");

User user = new User()
{
    Alias = "PedroElUno",
    Name = "Pedro Gutierrez",
    Password = "pass",
    MobilePhone = "+549-03445-470663"
};
Console.WriteLine(user.MobilePhone);
Console.WriteLine(user.ReturnNumericMobile());