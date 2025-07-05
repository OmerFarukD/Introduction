
// todo: Kullanıcıdan kaç adet sayı girmek istediğini alınız.
// girmiş olduğu her sayının toplamını 
// ortalamasını alan kodu yazınız.
int[] numbers = GetArray();
var result = ProcessSumAndAverage(numbers);
PrintResults(result.sum, result.avg);


(double sum , double avg) ProcessSumAndAverage(int[] array)
{
    double toplam = 0;
    foreach (int num in array)
    {
        toplam = toplam + num;
    }
    double average = toplam / array.Length;
    return (toplam, average);
}

int[] GetArray()
{
    Console.WriteLine("Lütfen kaç adet sayı almak istediğinizi yazınız.");
    int count = Convert.ToInt32(Console.ReadLine());


    int[] numbers = new int[count];
    for (int i = 0; i < count; i++)
    {
        // String interpolation
        Console.WriteLine($"{i + 1}. Sayı : ");
        int number = Convert.ToInt32(Console.ReadLine());

        numbers[i] = number;
    }

    return numbers;
}

void PrintResults(double toplama , double ortalama)
{
    Console.WriteLine($"Dizinin ortalaması : {ortalama}");
    Console.WriteLine($"Dizinin toplamı : {toplama}");
}