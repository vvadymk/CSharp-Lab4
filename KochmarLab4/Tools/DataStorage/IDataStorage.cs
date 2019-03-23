using System.Collections.Generic;
using KochmarLab4.Models;

namespace KochmarLab4.Tools.DataStorage
{
    internal interface IDataStorage
    {
        bool UserExists(Person person);
        void AddUser(Person user);
        List<Person> UsersList { get; }
    }
}
