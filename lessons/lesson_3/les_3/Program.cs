﻿

switch(4) {

    case (1):
    Console.Clear();
    string Method4(int count, string text) {
        string result = String.Empty;
        for(int i = 0; i < count; i++) {
            result = result + text;
        }
        return result;
    }
    string res = Method4(10, "z");
    Console.WriteLine(res);

    break;

    case (2):
    Console.Clear();

    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();   
    }


    break;

    case (3):
    Console.Clear();

    string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

    // string s = "qwerty"
    //               012
    // s[3] // r              

    string Replace(string text, char oldValue, char newValue)
    {
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
    }
    string newText = Replace(text, ' ', '|');
    Console.WriteLine(newText);

    break;
    




    case (4):
    // 
    // 
    // 

    Console.Clear();

    int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

    void PtintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {  
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    void selectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
                {
                    minPosition = j;
                }
            }
                int temporary = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temporary;
        }
    }

    PtintArray(arr);
    selectionSort(arr);

    PtintArray(arr);
    // 
    // 
    //     
    break;
}