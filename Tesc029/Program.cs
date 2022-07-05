// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FullArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index<lenght)
    {
        array[index] = new Random().Next(1,100);
        index++;
    }
}
void PrintArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while(index<lenght-1)
    {
        Console.Write(array[index] + ", ");
        index++;
    }
    Console.Write(array[index]);

}
int []array = new int[8];
FullArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");