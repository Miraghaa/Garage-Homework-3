//1ci tapsiriq 
//int FindCharIndex(string soz, char herf)
//{
//    for (int i = 0; i < soz.Length; i++)
//    {
//    if (soz[i] == herf)
//    {
//        return i;
//    }
//}
//return -1;
//}

//Console.WriteLine(FindCharIndex("miragha", 'i'));



// 2ci tapsiriq 
//string CalcAvg(params int[] data)
//{
//    int result = 0;
//    int count = 0;
//    foreach (var item in data)
//    {
//         result += item;
//        count++;
//    }
//    if(result/count > 60)
//    {
//        return "mezun oldunuz";
//    }
//    return "mezun ola bilmediniz"; 
//}

//Console.WriteLine(CalcAvg(100,80,60,25,40));


// 3cu tapsiriq 
//string IsPrime(int value)
//{
//    int count = 0;
//    if (value < 0 || value == 0 ||value == 1) return "Is valid number";
//    for (int i = 1; i * i <= value; i++)
//    {
//        if (value % i == 0)
//        {
//            count++;
//        }
//    }
//    if (count == 1) return "true";
//    else return "false";
//}

//Console.WriteLine(IsPrime(0));


// 4cu tapsiriq 
//int HighResult(int number1, int number2, int number3)
//{
//    if(number1 > number2 && number1 > number3)
//    {
//        return number1;
//    }
//    else if(number2 > number1 && number2 > number3)
//    {
//        return number2;
//    }
//    else
//    {
//        return number3;
//    }
//}

//Console.WriteLine(HighResult(-5,-2,-10));