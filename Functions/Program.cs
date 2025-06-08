
// Kullanıcıdan sayıları al.
// işlemi de alsın 
// işleme sok  (+ - * /)
// ekran çıktılarını göstersin.



var inputs = GetAllInputs2();
Proccess(inputs.num1,inputs.num2,inputs.op);




// 1355411234 

// out : parametreden değer üretme işlemi için kullanılır.



(double num1, double num2, string op) GetAllInputs2()
{
    double a = GetNumber(1);
    double b = GetNumber(2);
    string islem = GetOperator();

    return (a, b, islem);
}

void GetAllInputs(out double number1, out double number2,out string a)
{
    number1 = GetNumber(1);
    number2 = GetNumber(2);
    a = GetOperator();
}


void Proccess(double a, double b, string @operator)
{
    double result = 0;

    if (@operator == "+")
    {
        result = Sum(a,b);
    }
    else if (@operator == "-")
    {
        result = Difference(a,b);
    }
    else if (@operator == "/")
    {
        result = Divide(a,b);
    }
    else if (@operator == "*")
    {
        result = Multiply(a,b);
    }
    else
    {
        Console.WriteLine("Yanlış işlem seçtiniz.");
    }

    Console.WriteLine($"{a} {@operator} {b} = {result}");

}

string GetOperator()
{
    Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
    string islem = Console.ReadLine();
    return islem;
}


double GetNumber(int order)
{
    Console.WriteLine($"Lütfen {order}. sayıyı giriniz.");
    double number = Input();

    return number;
}



void SayHello()
{
    Console.WriteLine("Merhabalar");
}


// dönüş_tipi fonksiyon_ismi(parametreler){ ...  return değer;}

double Sum(double a, double b)
{
    return a + b;
}

double Input()
{
    return Convert.ToDouble(Console.ReadLine());
}
double Multiply(double a, double b)
{
    return a * b;
}

double Difference(double a, double b)
{
    return a - b;
}


double Divide(double a, double b)
{
    return a / b;
}



