

string[] array = PrintStrAndGetArray("Введите массив (через пробел)");

int length = array.Length;
int size = 0;
for (int i = 0; i < length; i++)
{
    if (array[i].Length < 4) size++;
}
if (size > 0)
{
    string[] newarray = new string[size];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[count] = array[i];
            count++;
        }
    }
Console.WriteLine(PrintArray(newarray));
}
else Console.WriteLine("[]");


string PrintArray(string[] array) // пишем массив в строку
{
    string str = "[" + string.Join(", ", array) + "]";
    return str;
}

string[] PrintStrAndGetArray(string message) // пишем сообщение и задаем массив строк
{
    Console.WriteLine(message);

    string inputString = (Console.ReadLine());
    string[] array = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return array;
}