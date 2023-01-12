// изучение методов


// // первый метод, ни чего не возвращают и ни чего не принимают

// void Method1()
// {
// Console.WriteLine(" Автор .....");
// }

// // вызов метода
// Method1(); // правильно вызванный метод
// Method1;   // не правильно вызванный метод



// второй метод, ни чего не взвращают но принимают агрументы

// void Method2(string msg)
// {
//     Console.WriteLine(msg);

// }

// //  Method2(msg: "текст сообщения");

//  void Method21(string msg, int count)
//  {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
//  }
// //  Method21("текст", 4);
//  Method21(count: 4, msg: "новый текст");

// третий метод что то возвращает но ни чего не принимает 

// int Method3()
// {
//     return DateTime.Now.Year;
// }
//  int year =  Method3();
//  Console.WriteLine(year);




// четвертая группа, что то принимает и что то возвращает

// string Method4 (int count, string Text)
// {
// int i = 0;
// string result = string.Empty;
//     while(i < count)
//     {
//         result = result + Text;
//         i++;
//     }
//     return result;
// }

// string res = Method4 (10, "asdf");
// Console.WriteLine(res); 


// рассмотрим пример с циклом for

// string Method4 (int count, string Text)
// {
//     string result = string.Empty;
//    for (int i = 0; i < count; i++)
//     {
//         result = result + Text;

//     }
//     return result;
// }
// string res = Method4 (10, "asdf, ");
// Console.WriteLine(res);

// рассмотрим цикл в цикле, таблица умножения
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j } = {i * j}");
//     }
//     Console.WriteLine();
// }


// решим задачу!

// дан текст, в тексте нужно все пробелы заменить черточками, 
// маленькие буквы к заменить на большие К, 
// а маленькие с заменить на большие С.

// string "- Я думаю, - сказал князь, улыбаясь, - что, "
// "ежели бы вас послали вместо нашего милого Винценгероде,"
// "вы бы взяли приступом согласие проусского короля."
// "Вы так красноречивы. Вы дадите мне чаю?";

// подсказка для решения
// string s = "qwerty"
//             012345
// s[3] == r;



// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие проусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char OldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == OldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }


// string newText = Replace(text, ' ', '/');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);


// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);



// задание номер пять, упорядочить от минимального по возрастанию

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void printArrey(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void selectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPossition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPossition]) minPossition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPossition];
//         array[minPossition] = temporary;
//     }
// }

// printArrey(arr);
// selectionSort(arr);


// printArrey(arr);
