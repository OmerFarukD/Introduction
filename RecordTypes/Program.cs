
//Employee employee = new Employee
//{
//    Name = "Çalışan",
//    Surname = "Deneme",
//    Salary = 25000
//};


//employee.Name = "Ömersu";

//Console.WriteLine(employee);
Customer customer = new Customer("Buse","Qubit",27);
Customer customer1 = new Customer("Buse", "Qubit", 22);

Customer customer2 = customer with { Name="Ömer" };



Console.WriteLine(customer);
Console.WriteLine(customer2);

Console.WriteLine(customer == customer1);


//Employee employee1 = new Employee
//{
//    Name = "Çalışan",
//    Surname = "Deneme",
//    Salary = 25000
//};
//Console.WriteLine(employee == employee1);

Point point;

Point p1 = new Point { X = 2 , Y=6};
Point p2 = new Point { X = 2, Y = 6 };


point.X = 1;
point.Y = 2;

Console.WriteLine(point.X);
point.X = 150;

Console.WriteLine(point.X);


Console.WriteLine(p1.X==p2.X);

User user = new User("Buse","Sultan");
User user1 = new User("Buse", "Sultan");
Console.WriteLine(user);
Console.WriteLine(user==user1);
//user.Name = "asdf";

// record :  veri tutan immutable light class

// default olarak ToString methodu override edilmiş şekilde gelir.
// Karşılaştırma işlemi yapılırken referanslar değil değerleri karşılaştırılır.
// classlar gibi referans tiplidir.

record Customer(string Name, string Surname, int Age);

readonly record struct User(string Name, string Surname);




// verileri genel olarak stackte tutar ama yerine göre heap de de tutabilir.
// new anahtar sözcüğü kullanmaya gerek yoktur. 
struct Point
{
    public int X;
    public int Y;
}


class Triangle
{
    public Point Top;
    public Point BottomLeft;
    public Point BottomRight;
}

class Employee
{
    public string Name;
    public string Surname;
    public double Salary;


    public override string ToString()
    {
        return $"Name : {Name}, Surname : {Surname}, Salary : {Salary}";
    }
}


