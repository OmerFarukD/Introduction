// Özellik tutan  - Hastane lokasyonu , Hastane Adı 
// İş yükünü üstlenen - Randevu_Alma , Randevu_İptal Etme
// SOLID 
// Single Responsibility 


// TODO : Bir kişi Randevu almak istiyor. 
// Randevu alacak hastanın Adı soyadı yaş bilgileri isteniyorr.
// Doktor ismi, soyisim ve uzmanlık alanı da isteniyor.
// Burada randevunun bilgi özetini işlem sonunda kullanıcı istemektedir.


// TODO : Doktorlar dan  Cinsiyet bilgisi eklenmektedir.


//Patient p = new Patient();
//p.Name = "Ömer";
//p.Surname = "Qubit";
//p.Age = 25;

//Patient p1 = new Patient();
//p1.Name = "ASD";
//p1.Surname = "DSA";
//p1.Age = 35;

//Patient p3 = new Patient()
//{
//    Age = 25,
//    Name = "Buse",
//    Surname = "Qubit"
//};

//Patient p4 = new()
//{
//    Surname = "",
//    Name = "",
//    Age =0
//};

//var p5 = new Patient()
//{

//    Age = 25,
//    Name = "Buse",
//    Surname = "Qubit"
//};

//Doctor doctor = new Doctor
//{
//    Name = "Buse",
//    Surname = "Qubit",
//    Speciality = "Kardiyoloji"
//};


//Appointment appointment = new Appointment()
//{
//    Doctor = doctor,
//    Patient = p,
//    DateTime = new DateTime(2025, 7, 23, 15, 0, 0)
//};


//Console.WriteLine(appointment);

// Özellik tutan classlar.


AppointmentManger appointmentManger = new AppointmentManger();
Appointment appointment1 = appointmentManger.GetAppointmentInfo();
Console.WriteLine(appointment1);

class Patient 
{

    // field 
    public string Name;
    public string Surname;
    public int Age;

    public override string ToString()
    {
        return $"Hasta adı : {Name}, Soyadı : {Surname}, Yaş : {Age}";
    }
}
class Doctor
{
    public string Name;
    public string Surname;
    public string Speciality;
    public string Gender;



    public override string ToString()
    {
        return $"Doktor Adı : {Name} , Soyadı : {Surname}, Uzmanlığı : {Speciality}, Cinsiyet : {Gender}";
    }
}

class Appointment
{
    public Doctor Doctor;

    public Patient Patient;

    public DateTime DateTime;



    public override string ToString()
    {
        return $"Hasta Bilgisi : \n  {Patient} \n Doktor Bilgisi : {Doctor} \n Randevu Tarihi : {DateTime.Day} / {DateTime.Month} / {DateTime.Year}  - {DateTime.Hour}:{DateTime.Minute}";
    }
}


// İş yükü oluşturan classlar.
class PatientManager
{
   public Patient GetPatientInfo()
    {
        Console.WriteLine("Lütfen hasta adını giriniz. ");
        string name = Console.ReadLine();

        Console.WriteLine("Lütfen hasta Soyadını giriniz. ");
        string surname = Console.ReadLine();


        Console.WriteLine("Lütfen hasta Yaşını giriniz. ");
        int age = Convert.ToInt16(Console.ReadLine());


        Patient patient = new Patient
        {
            Name = name,
            Surname = surname,
            Age = age
        };

        return patient;
    }


   public (string name, string surname, int age) GetPatientInfoTuple()
    {

        Console.WriteLine("Lütfen hasta adını giriniz. ");
        string name = Console.ReadLine();

        Console.WriteLine("Lütfen hasta Soyadını giriniz. ");
        string surname = Console.ReadLine();


        Console.WriteLine("Lütfen hasta Yaşını giriniz. ");
        int age = Convert.ToInt16(Console.ReadLine());


        return (name, surname, age);
    }
}

class DoctorManager
{
    public Doctor GetDoctorInfo()
    {
        Console.WriteLine("Lütfen Doktor adını giriniz. ");
        string name = Console.ReadLine();

        Console.WriteLine("Lütfen Doktor Soyadını giriniz. ");
        string surname = Console.ReadLine();

        Console.WriteLine("Lütfen Doktor Uzmanlığını  giriniz. ");
        string speciality = Console.ReadLine();

        Console.WriteLine("Lütfen Doktor Cinsiyetini giriniz.");
        string gender = Console.ReadLine();


        Doctor doctor = new Doctor
        {
            Name = name,
            Surname = surname,
            Speciality = speciality,
            Gender = gender
        };

        return doctor;
    }
}


class AppointmentManger
{
    // SOLID 
    // Open Closed

    PatientManager patientManager = new();
    DoctorManager doctorManager = new();


   public Appointment GetAppointmentInfo()
    {


        Patient patient = patientManager.GetPatientInfo();

        Doctor doctor = doctorManager.GetDoctorInfo();

        DateTime appointmentDate = GetDateTime();

      
        Appointment appointment = new Appointment
        {
            Patient = patient,
            DateTime = appointmentDate,
            Doctor = doctor
        };


        return appointment;
    }

    DateTime GetDateTime()
    {
        Console.WriteLine("Lütfen gün bilgisini yazınız.");
        int day = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Lütfen ay bilgisini giriniz.");
        string monthName = Console.ReadLine();

        Console.WriteLine("Lütfen yıl bilgisini yazınız.");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen Randevu saatini giriniz.");
        int hour = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen Randevu dakikasını giriniz.");
        int minute = Convert.ToInt32(Console.ReadLine());


        // Ocak , OCAK , OcAk,OCak
        int month = monthName.ToLower().Trim() switch
        {
            "ocak" => 1,
            "şubat" => 2,
            "mart" => 3,
            "nisan" => 4,
            "mayıs" => 5,
            "haziran" => 6,
            "temmuz" => 7,
            "ağustos" => 8,
            "eylül" => 9,
            "ekim" => 10,
            "kasım" => 11,
            "aralık" => 12,
            _ => 0
        };

        DateTime appointmentDate = new DateTime(year, month, day, hour, minute, 0);
        return appointmentDate;
    }
}

