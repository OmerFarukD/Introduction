// bir e ticaret web sitesi müşteri tarafından isteniyor. 
// Satıcı bir ürün kaydı yapmak istediği zaman şu kuralllara uymak durumundadır.

// Price ve Quantity alanı 0 dan büyük olmak zorundadır.
// Price alanı için %20 KDV li fiyatını sistem otomatik olarak ürünün fiyatı olarak kaydetmelidir.

// Sistemde kullanıcılar da olmalıdır


Console.WriteLine("Hello, World!");
Product product = new Product()
{
    Name = "asd",
    Category= "Deneme",
    Price=-12000,
    Quantity = -250
};


User user = new()
{
    FirstName = "Buse",
    LastName = "Qubit",
    Email = "qubitbuse@gmail.com",
    Password = "qubit1234"

};

user.FirstName = "asd";

user.Email = "email@gmail.com";

Category category = new Category("bİLGİSAYAR");
category.Name = "asdsads";

Console.WriteLine(user);
Console.WriteLine(product);
Console.WriteLine(product);
class Product
{
    private string _name;
    private double? _price;
    private int _quantity;


    public string Name { 
        get {
            return _name;
        }
        
        set {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Ürün adı alanı boş olamaz.");
                return;
            }

            _name = value;

        }
    }
    
    public double? Price { 
        get 
        {
            return _price;
        }

        set
        {
            if(value < 0)
            {
                Console.WriteLine("Ürün Fiyat değeri negatif olamaz.");
                return;
            }

            _price = value * 1.20;
        }
    
    }
    
    public int Quantity
    {
        get
        {
            return _quantity;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ürün Adet değeri negatif olamaz.");
                return;
            }

            _quantity = value;
        }

    }

    public string Category { get; set; }


    public override string ToString()
    {
        return $"Name : {Name}, Price: {Price}, Adet : {Quantity}, Kategori : {Category}";
    }
}



class User
{
    public string FirstName { get; init; }

    public string LastName { get; init; }


    // sadece okunabilir
    public string FullName => $"{FirstName} {LastName}";

    public string Email { get; set; }

    public string Password { private get; set; }


    public override string ToString()
    {
        return $"Tam Adı : {FullName}, Email : {Email}";
    }
}


public record Category(string Name);