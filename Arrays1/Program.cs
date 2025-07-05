using System.Collections;

//object[] arrays = new object[20];
//ArrayList list = new ArrayList();


//list.Add("Buse");
//list.Add("Ömer");
//list.Add(false);
//list.Add(1);

//foreach(var item in list)
//{
//    Console.WriteLine(item);
//}


string[] countries = { "Türkiye", "Almanya", "Fransa", "İsviçre" };
int[] numbers = { 1, 2, 3, 65, 87, 88, 95, 96, 145, 144, 21, 636 };
//                0  1  2   3   4   5   6   7    8   9    10  11
//                   +               +       +        +        +

//foreach(string country in countries)
//{
//    Console.WriteLine(country);
//}


Array.ForEach(countries, country => Console.WriteLine(country));
Array.Reverse(countries);
Console.WriteLine("-------------------------------------------");
Array.ForEach(countries, country => Console.WriteLine(country));
Array.Sort(countries);
Console.WriteLine("-------------------------------------------");
Array.ForEach(countries, country => Console.WriteLine(country));
Array.Reverse(countries);
Console.WriteLine("-------------------------------------------");
Array.ForEach(countries, country => Console.WriteLine(country));



// numbers dizisindeki çift sayıları ayrı bir dizide tutan ve bu diziyi ekran çıktısı olarak gösteren kodu yazınız.
//int count = 0;

//foreach(int num in numbers)
//{
//    if(num % 2 == 0)
//    {
//        count++;
//    }
//}

//int[] filtered = new int[count];
//int filtered_index = 0;
//for (int i = 0; i<numbers.Length; i++)
//{
//    if (numbers[i] %2 == 0)
//    {
//        filtered[filtered_index] = numbers[i];
//        filtered_index++;
//    }
//}


//foreach(int filteredNumbers in filtered)
//{
//    Console.WriteLine(filteredNumbers);
//}

// lambda ile gösterimi
int[] filtered = Array.FindAll(numbers, number => number % 2 == 0);
Array.ForEach(filtered, filteredNumber => Console.WriteLine(filteredNumber));


