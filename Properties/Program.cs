// bir e ticaret web sitesi müşteri tarafından isteniyor. 
// Satıcı bir ürün kaydı yapmak istediği zaman şu kuralllara uymak durumundadır.

// Price ve Quantity alanı 0 dan büyük olmak zorundadır.
// Price alanı için %20 KDV li fiyatını sistem otomatik olarak ürünün fiyatı olarak kaydetmelidir.

Product product = new();
product.SetName("Dyson Süpürge");
product.SetPrice(8500);
product.SetQuantity(2500);
product.SetCategory("Ev Aletleri");


Console.WriteLine(product);


class Product
{
    private string Name;
    private double? Price;
    private int Quantity;
    private string Category;



    // Getter : Dönüş Tipi istenilen alanın tippi ile aynı olmak zorundadır.
    // İlgili alanın değerinin okunması için kullanılır.
    public string GetName()
    {
        return Name;
    }

    // Setter : Dönüş Tipi void 
    // İlgili alanın değerinin atanması için kullanılır.

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Ürün Adı boş olamaz.");
        }
        else
        {
            Name = name;
        }
    }


    public double? GetPrice()
    {
        return Price;
    }

    public void SetPrice(double price)
    {
        if(price < 0)
        {
            Console.WriteLine("Ürün Fiyat alanı negatif olamaz.");
            return;
        }

        Price = price *1.20;

    }


    public int GetQuantity()
    {
        return Quantity;
    }

    public void SetQuantity(int quantity)
    {
        if (quantity < 0)
        {
            Console.WriteLine("Ürün adet alanı negatif olamaz.");
            return;
        }

        Quantity = quantity;

    }


    public string GetCategory()
    {
        return Category;
    }

    public void SetCategory(string category)
    {
        Category = category;
    }







    public override string ToString()
    {
        return $"Name : {Name}, Price: {Price}, Adet : {Quantity}, Kategori : {Category}";
    }
}



