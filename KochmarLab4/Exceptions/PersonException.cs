using System;

namespace KochmarLabs2_3.Exceptions
{
    class PersonException
    {
        
        internal class MaybeDiedPersonException : Exception
        {
            public MaybeDiedPersonException()
                : base("Person is toooo olddddd")
            {}
        }

        internal class NotEvenBorn : Exception
        {
            public NotEvenBorn()
                : base("Person hasn`t been born yet")
            {}
        }

        internal class EmailException : Exception
        {
            public EmailException()
                :base("Invalid email")
            {}
        }

        internal class FirstNameException : Exception
        {
            public FirstNameException()
                :base("Too short FirstName")
            { }
        }

        internal class LastNameException : Exception
        {
            public LastNameException()
                : base("Too short LastName")
            { }
        }
    }
}
