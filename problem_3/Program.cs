//  Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь;
// 0, 7, 8, -2, -2 -> 2;
// -1, -7, 567, 89, 223-> 3;

int[] StringToNumbers(string input)
{
    int countNumbers = 1; // счетчик чисел, перед запятой

    for (int i = 0; i < input.Length; i++) // строка это массив символов
    {
        if(input[i] == ',')
        {
            countNumbers++;
        }
    }

    int[] numbers = new int[countNumbers]; // Создаем массив
    int index = 0; //счетчик для массива чисел

    for (int i = 0; i < input.Length; i++) // перевод строки в число, записывается символ-число до запятой и конвертируется в число
    {
        string tempString = ""; // Временная строка. в которую запишем числа от запятой, до запятой

        while(input[i] != ',') // идем от запятой до запятой, записываем числа пока не столкнемся с запятой
        {
            if(i != input.Length - 1)// если число отрицательное
            {
                tempString += input[i].ToString(); // конвертация в строку
                i++;
            }
            else// 
            {
                tempString += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(tempString); //конвертируем строку в число
        index++;
    }

    return numbers;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int positiveNumber = 0;
// Метод подсчета колличества четных чисел в массиве
void PositivNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] > 0)
        positiveNumber++;
    }
    Console.WriteLine("Количество положительных чисел в массиве - " + positiveNumber);
}



Console.Write("Введите числа через запятую :");
int[] numbers = StringToNumbers(Console.ReadLine());
PrintArray(numbers);
PositivNumber(numbers);




