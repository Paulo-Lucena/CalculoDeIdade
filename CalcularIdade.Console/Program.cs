using CalcularIdade.Console.Entities;

Console.WriteLine("Informe seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Informe sua data de nascimento: ");
DateTime birthDay = DateTime.Parse(Console.ReadLine());

Person person = new Person(name, birthDay);
Console.WriteLine("");
Console.WriteLine(person.ToString());