using DataModels;

Console.WriteLine("Hello, World!");


Student s1 = new Student(1, "S", "W", "s33324", "SWE");
Employee e1 = new Employee(2, "A", "W", "Boss", 1000000);

List<Person> persons = new List<Person>();

persons.Add(s1);
persons.Add(e1);

var tmp0 = persons[0];
var tmp1 = persons[1];


Console.ReadKey();

