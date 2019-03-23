using System;
using System.Collections.Generic;
using System.IO;
using KochmarLab4.Models;
using KochmarLab4.Tools.Managers;

namespace KochmarLab4.Tools.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<Person> _users;

        internal SerializedDataStorage()
        {
            try
            {
                _users = SerializationManager.Deserialize<List<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _users = new List<Person>();
              
                Random random = new Random();

                for (int i = 0; i < 50; ++i)
                {
 
                    AddUser(new Person(Person.FirstNames[i], Person.LastNames[i], Person.FirstNames[i] + "." + Person.LastNames[i] + Person.Emails[random.Next(0, 3)], new DateTime(random.Next(1880, 2019), random.Next(1, 12), random.Next(1, 28))));
                }

                SaveChanges();
            }
        }

        public bool UserExists(Person person)
        {
            return _users.Contains(person);
        }

        public void AddUser(Person user)
        {
            _users.Add(user);
            SaveChanges();
        }

        public List<Person> UsersList
        {
            get { return _users; }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        }

    }
}
