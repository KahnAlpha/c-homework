
int[] array = new int[10];
int a;
Console.WriteLine("enter the array elements sorted");
for (int i = 0; i < 10; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int biggest = array[0];
for (int i = 0; i < 10; i++)

{
    if (array[i] > biggest)
    {
        biggest = array[i];

    }

}
Console.WriteLine("Biggest number is:=" + biggest);
