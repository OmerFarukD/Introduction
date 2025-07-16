// Özellik tutan  - Hastane lokasyonu , Hastane Adı 
// İş yükünü üstlenen - Randevu_Alma , Randevu_İptal Etme
// SOLID 
// Single Responsibility 


// TODO : Bir kişi Randevu almak istiyor. 
// Randevu alacak hastanın Adı soyadı yaş bilgileri isteniyorr.
// Doktor ismi, soyisim ve uzmanlık alanı da isteniyor.
// Burada randevunun bilgi özetini işlem sonunda kullanıcı istemektedir.


Patient p = new Patient();
p.Name = "Ömer";
p.Surname = "Qubit";
p.Age = 25;

Patient p1 = new Patient();
p1.Name = "ASD";
p1.Surname = "DSA";
p1.Age = 35;

Patient p3 = new Patient()
{
    Age = 25,
    Name = "Buse",
    Surname = "Qubit"
};

Patient p4 = new()
{
    Surname = "",
    Name = "",
    Age =0
};

var p5 = new Patient()
{

    Age = 25,
    Name = "Buse",
    Surname = "Qubit"
};

Console.WriteLine(p3);

string text = p3.ToString();
Console.WriteLine(text);


class Patient 
{

    // field 
    public string Name;
    public string Surname;
    public int Age;

   //public void EkranaYaz()
   // {
   //     Console.WriteLine($"Hasta Adı : {Name}");
   //     Console.WriteLine($"Hasta Soyadı  : {Surname}");
   //     Console.WriteLine($"Hasta yaşı : {Age}");
   // }

    public override string ToString()
    {
        return $"Hasta adı : {Name}, Soyadı : {Surname}, Yaş : {Age}";
    }



}




