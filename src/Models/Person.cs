using System.Collections.Generic;

namespace src.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string CPF { get; set; }
    public bool Active { get; set; }
    public List<Contract> Contracts { get; set; }

    public Person(string name, int age, string cpf)
    {
        Name = name;
        Age = age;
        CPF = cpf;
        Active = true;
        Contracts = new List<Contract>();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nAge: {Age}\nCPF: {CPF}";
    }
}