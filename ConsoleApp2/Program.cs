﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int[] tab = { 1, 2, 3, 4, 5 };

Console.WriteLine(GetAvg([1,2,3,4,5]));
Console.WriteLine(GetMax([1,2,3,4,5]));

static double GetAvg(int[] tab) {
    int sum = 0;
    foreach (var num in tab)
    {
        sum += num;
        

    }

    return (double)sum / tab.Length;
}

static int GetMax(int[] tab) {
    int max = 0;
    foreach (var num in tab) {
        if (num > max) {
            max = num;
        }
    }
    return max;
}
