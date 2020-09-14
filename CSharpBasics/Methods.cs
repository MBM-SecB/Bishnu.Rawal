using System;

public class MethodTeacher
{
    // Simple-method:  takes 2 arguemnts, and returns a value
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }

    // Generic method
    public void Multiply<T>(T firstNum, T secondNum)
    {
        
    }

    // Variable-number of arguments
    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product = product * num;
        }

        return product;
    }

    // Named-agruments
    internal void PrintCustomerDetails(string name, byte age, string address, DateTime dob)
    {
        // Using string interpolation here: $"{}"
        Console.Write($"Customer Details: {name}, {age}, {address}, {dob}");
    }

    // Returning multiple value
    // Question1: Method which returns max and min value of supplied numbers
    internal (int, int) FindMinMax(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        return (min, max);
    }


}

public class MethodTester
{
    void TestMethods()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int product = methodTeacher.Multiply(2345, 56483);

        methodTeacher.Multiply<decimal>(234.54m, 345678.234566m);

        product = methodTeacher.Multiply(344, 56767, 233, 55667);
        product = methodTeacher.Multiply(344, 56767, 233, 55667, 345, 123, 45);

        methodTeacher.PrintCustomerDetails(dob: DateTime.Now, name: "Bishnu", age: 34, address: "");

        (int Min, int Max) result = methodTeacher.FindMinMax(2, 3, 4, 5, 6, 12, 34, 23, 45, 67, 445, 32);

        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");
    }
}