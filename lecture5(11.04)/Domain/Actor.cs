using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Actor
{
    public int Id { get; private init; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string PhoneNumber { get; private set; }
    public DateTime DateOfBirth { get; private init; }

    public string FullName => $"{Surname} {Name}";

    public Actor(string name, string surname, string phoneNumber, DateTime dateOfBirth)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"\"{nameof(name)}\" не может быть неопределенным или пустым.", nameof(name));
        }

        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
    }
}
