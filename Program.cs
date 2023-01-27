
string[] FindLessThan(string[] input, int n) //
{
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n) //
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] InputArray() // ввод данных в массив, разделение через пробел
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

Console.Clear();
string[] array = InputArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

