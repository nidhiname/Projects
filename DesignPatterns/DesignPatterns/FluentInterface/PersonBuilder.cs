namespace DesignPatterns.FluentInterface
{
    namespace FluentInterface
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public class PersonBuilder
        {
            private Person _person = new Person();

            public PersonBuilder SetFirstName(string firstName)
            {
                _person.FirstName = firstName;
                return this;
            }

            public PersonBuilder SetLastName(string lastName)
            {
                _person.LastName = lastName;
                return this;
            }

            public PersonBuilder SetAge(int age)
            {
                _person.Age = age;
                return this;
            }

            public Person Build()
            {
                return _person;
            }
        }
    }

}
