using System;

namespace KochmarLab4.Models
{
    [Serializable]
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _eMail;
        private DateTime _birthDate;
        private int _age = -1;
        private readonly string[] _westernZodiac =
            {"Capricorn", "Aquarius", "Pisces", "Aries", "Taurus","Gemini","Cancer","Leo", "Virgo", "Libra", "Scorpio","Sagittarius"};
        private readonly string[] _chineseZodiac =
            {"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Rooster", "Dog", "Pig"};


        public Person(string fistName, string lastName, string email, DateTime birthDate)
        {
            _firstName = fistName;
            _lastName = lastName;
            _eMail = email;
            _birthDate = birthDate;

        }

        public Person()
        {
        
        }
        public Person(string fistName, string lastName, string email)
        {
            _firstName = fistName;
            _lastName = lastName;
            _eMail = email;
        }

        public Person(string fistName, string lastName, DateTime birthDate)
        {
            _firstName = fistName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public bool IsAdult => Age >= 18;

        public string FirstName => _firstName;

        public string LastName => _lastName;

        public string Email => _eMail;

        private int Age
        {
            get
            {
                _age = DateTime.Today.Year - _birthDate.Year;
                if (DateTime.Today.Month < _birthDate.Month)
                {

                    return --_age;
                }
                if ((DateTime.Today.Month >= _birthDate.Month)
                         && (DateTime.Today.Day < _birthDate.Day))
                {

                    return --_age;
                }

                return _age;
            }
        }

        public DateTime DateOfBirth => _birthDate;

        public string WesternZodiac => WesternZodiacCount();

        public string ChineseZodiac => ChineseZodiacCount();

        public bool IsBirthday => IsBirthdayCount();


        private string WesternZodiacCount()
        {
            var day = _birthDate.Day;
            switch (_birthDate.Month)
            {
                case 12 when day >= 22:
                //dec-jan
                case 1 when day <= 20:
                    return _westernZodiac[0];
                case 1 when day >= 21:
                //jan-feb
                case 2 when day <= 18:
                    return _westernZodiac[1];
                case 2 when day >= 19:
                //feb-march
                case 3 when day <= 20:
                    return _westernZodiac[2];
                case 3 when day >= 21:
                //march-apr
                case 4 when day <= 20:
                    return _westernZodiac[3];
                case 4 when day >= 21:
                // apr-may
                case 5 when day <= 20:
                    return _westernZodiac[4];
                case 5 when day >= 21:
                //may-june
                case 6 when day <= 21:
                    return _westernZodiac[5];
                case 6 when day >= 22:
                //june-july
                case 7 when day <= 22:
                    return _westernZodiac[6];
                case 7 when day >= 23:
                //july-aug
                case 8 when day <= 23:
                    return _westernZodiac[7];
                case 8 when day >= 24:
                //aug-sept
                case 9 when day <= 23:
                    return _westernZodiac[8];
                case 9 when day >= 24:
                //sept-oct
                case 10 when day <= 23:
                    return _westernZodiac[9];
                case 10 when day >= 24:
                //oct-nov
                case 11 when day <= 22:
                    return _westernZodiac[10];
                default:
                    return _westernZodiac[11];
            }

        }
        private string ChineseZodiacCount()
        {
            switch (_birthDate.Year)
            {
                case 1912:
                case 1924:
                case 1936:
                case 1948:
                case 1960:
                case 1972:
                case 1984:
                case 1996:
                case 2008:
                    return _chineseZodiac[0];
                case 1913:
                case 1925:
                case 1937:
                case 1949:
                case 1961:
                case 1973:
                case 1985:
                case 1997:
                case 2009:
                    return _chineseZodiac[1];
                case 1914:
                case 1926:
                case 1938:
                case 1950:
                case 1962:
                case 1974:
                case 1986:
                case 1998:
                case 2010:
                    return _chineseZodiac[2];
                case 1915:
                case 1927:
                case 1939:
                case 1951:
                case 1963:
                case 1975:
                case 1987:
                case 1999:
                case 2011:
                    return _chineseZodiac[3];
                case 1916:
                case 1928:
                case 1940:
                case 1952:
                case 1964:
                case 1976:
                case 1988:
                case 2000:
                case 2012:
                    return _chineseZodiac[4];
                case 1917:
                case 1929:
                case 1941:
                case 1953:
                case 1965:
                case 1977:
                case 1989:
                case 2001:
                case 2013:
                    return _chineseZodiac[5];
                case 1918:
                case 1930:
                case 1942:
                case 1954:
                case 1966:
                case 1978:
                case 1990:
                case 2002:
                case 2014:
                    return _chineseZodiac[6];
                case 1919:
                case 1931:
                case 1945:
                case 1955:
                case 1967:
                case 1979:
                case 1991:
                case 2003:
                case 2015:
                    return _chineseZodiac[7];
                case 1920:
                case 1932:
                case 1944:
                case 1956:
                case 1968:
                case 1980:
                case 1992:
                case 2004:
                case 2016:
                    return _chineseZodiac[8];
                case 1921:
                case 1933:
                case 1957:
                case 1969:
                case 1981:
                case 1993:
                case 2005:
                case 2017:
                    return _chineseZodiac[9];
                case 1922:
                case 1934:
                case 1946:
                case 1958:
                case 1970:
                case 1982:
                case 1994:
                case 2006:
                case 2018:
                    return _chineseZodiac[10];
                default:
                    return _chineseZodiac[11];
            }
        }
        private bool IsBirthdayCount()
        {
            return (DateOfBirth.Day == DateTime.Today.Day && DateOfBirth.Month == DateTime.Today.Month);
        }

        //private void ValidAge(int age)
        //{
        //    if (age > 150)
        //        throw new PersonException.MaybeDiedPersonException();

        //    if (age < 0)
        //        throw new PersonException.NotEvenBorn();
        //}

        //private void ValidEmail(string email)
        //{
        //    if (!new EmailAddressAttribute().IsValid(email))
        //        throw new PersonException.EmailException();
        //}

        //private void ValidFirstName(string str)
        //{
        //    if (str.Length < 2)
        //        throw new PersonException.FirstNameException();
        //}

        //private void ValidLastName(string str)
        //{
        //    if (str.Length < 2)
        //        throw new PersonException.LastNameException();
        //}

        public static readonly string[] FirstNames =
            {
                "Oliver",
                "Harry",
                "George",
                "Jack",
                "Jacob",
                "Noah",
                "Charlie",
                "Muhammed",
                "Thomans",
                "Oscar",
                "William",
                "James",
                "Leo",
                "Alfie",
                "Henry",
                "Joshua",
                "Freddie",
                "Archie",
                "Ethan",
                "Isaac",
                "Alexander",
                "Joseph",
                "Edward",
                "Samuel",
                "Max",
                "Logan",
                "Lucas",
                "Daniel",
                "Theo",
                "Arhur",
                "Mohammed",
                "Harrison",
                "Benjamin",
                "Mason",
                "Finley",
                "Sebastian",
                "Adam",
                "Dylan",
                "Zachary",
                "Riley",
                "Teddy",
                "Theodore",
                "David",
                "Elijah",
                "Jake",
                "Toby",
                "Louie",
                "Reuben",
                "Arlo",
                "Hugo"
            };

        public static readonly string[] LastNames =
        {
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor",
                "Anderson",
                "Thomas",
                "Jackson",
                "White",
                "Harris",
                "Martin",
                "Thompson",
                "Garcia",
                "Martinez",
                "Robinson",
                "Clark",
                "Rodriguez",
                "Lewis",
                "Lee",
                "Walker",
                "Hall",
                "Allen",
                "Young",
                "Hernandez",
                "King",
                "Wright",
                "Lopez",
                "Hill",
                "Scott",
                "Green",
                "Adams",
                "Baker",
                "Gonzalez",
                "Nelson",
                "Carter",
                "Mitchell",
                "Perez",
                "Roberts",
                "Turner",
                "Phillips",
                "Campbell",
                "Parker",
                "Evans",
                "Edwards",
                "Collins"
            };

        public static readonly string[] Emails =
        {
            "@gmail.com",
             "@yahoo.com",
            "@mail.ru"
        };
    }

}
