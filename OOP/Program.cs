// Özellik tutan  - Hastane lokasyonu , Hastane Adı 
// İş yükünü üstlenen - Randevu_Alma , Randevu_İptal Etme
// SOLID 
// Single Responsibility 


// TODO : Bir kişi Randevu almak istiyor. 
// Randevu alacak hastanın Adı soyadı yaş bilgileri isteniyorr.
// Doktor ismi, soyisim ve uzmanlık alanı da isteniyor.
// Burada randevunun bilgi özetini işlem sonunda kullanıcı istemektedir.


var patient = GetPatientInfo();
var doctor = GetDoctorInfo();
var appointment = GetAppointmentDateTime();
string patientFullName = $"{patient.name} {patient.surname}";
string doctorFullName = doctor.name + " "+ doctor.surname;
GetAppointmentSummaries(patientFullName,patient.age,appointment, doctorFullName, doctor.speciality);


(string name, string surname, int age) GetPatientInfo()
{

    Console.WriteLine("Lütfen hasta adını giriniz. ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen hasta Soyadını giriniz. ");
    string surname = Console.ReadLine();


    Console.WriteLine("Lütfen hasta Yaşını giriniz. ");
    int age = Convert.ToInt16(Console.ReadLine());


    return (name, surname, age);
}


(string name, string surname,string speciality) GetDoctorInfo()
{
    Console.WriteLine("Lütfen Doktor adını giriniz. ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen Doktor Soyadını giriniz. ");
    string surname = Console.ReadLine();

    Console.WriteLine("Lütfen Doktor Uzmanlığını  giriniz. ");
    string speciality = Console.ReadLine();

    return (name, surname, speciality);
}




//(int day, string month , int year) GetAppointmentDate()
//{
//    Console.WriteLine("Lütfen gün bilgisini yazınız.");
//    int day = Convert.ToInt32(Console.ReadLine());


//    Console.WriteLine("Lütfen yıl bilgisini yazınız.");
//    int year = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Lütfen ay bilgisini giriniz.");
//    string month = Console.ReadLine();

//    return (day, month, year);

//}


DateTime GetAppointmentDateTime()
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

    DateTime appointmentDate = new DateTime(year,month,day,hour,minute,0);

    return appointmentDate;
}

//void GetAppointmentSummaries(string patientFullName, int patientAge, int day, string month, int year, string doctorFullname, string doctorSpeciality)
//{
//    Console.WriteLine("Hasta Bilgileri");
//    Console.WriteLine("----------------------------------");
//    Console.WriteLine($"Hasta Ad ve Soyadı : {patientFullName}");
//    Console.WriteLine($"Hasta yaşı : {patientAge}");
//    Console.WriteLine($"Doktor Bilgileri");
//    Console.WriteLine("-----------------------------------");
//    Console.WriteLine($"Doktor Ad ve Soyad : {doctorFullname}");
//    Console.WriteLine($"Doktor Uzmanlığı : {doctorSpeciality}");
//    Console.WriteLine($"Randevu Tarihi : {day} / {month} / {year}");
//}


void GetAppointmentSummaries(string patientFullName, int patientAge, DateTime time, string doctorFullname, string doctorSpeciality)
{
    Console.WriteLine("Hasta Bilgileri");
    Console.WriteLine("----------------------------------");
    Console.WriteLine($"Hasta Ad ve Soyadı : {patientFullName}");
    Console.WriteLine($"Hasta yaşı : {patientAge}");
    Console.WriteLine($"Doktor Bilgileri");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Doktor Ad ve Soyad : {doctorFullname}");
    Console.WriteLine($"Doktor Uzmanlığı : {doctorSpeciality}");
    Console.WriteLine($"Randevu Tarihi : {time.Day} / {time.Month} / {time.Year}  Saat : {time.Hour} : {time.Minute}");
}