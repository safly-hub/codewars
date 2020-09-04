using System;

public static class Kata
{
    public static string Greet(string name)
    {
        return $"Hello, {name} how are you doing today?";
    }

    public static string SwitchItUp(int number)
    {
        string[] numbers =
                    { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

        return numbers[number];
    }

}

