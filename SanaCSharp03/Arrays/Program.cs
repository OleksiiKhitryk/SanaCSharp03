System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("Enter please the lenght of array");

int count, elementEqual = 0, maxArrayElementIndex = 0, sumPositiveElementArrayIndex = 0, quantityIntegerInArray = 0; 
double sumNegativeElementArray = 0, maxArrayElement, maxArrayElementOnModule = 0;

Console.Write("n = ");
count = int.Parse(Console.ReadLine());

if (count <= 0)
{
    Console.WriteLine("Error!Lenght of array n <= 0 ");
    return;
}
else
{
    double[] array = new double[count];

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Array element[{i}] = ");
        array[i] = double.Parse(Console.ReadLine());
        if (array[i] < 0)
            sumNegativeElementArray += array[i];
        if (array[i] > 0)
            sumPositiveElementArrayIndex += i;
        else
            sumPositiveElementArrayIndex = -1;
        if ((array[i] - Math.Round(array[i])) == 0)
            quantityIntegerInArray++; 
    }

    maxArrayElement = array[0];
    for (int i = 0; i < count - 1; i++)
    {
        if (array[i] > array[i + 1] && array[i] >= maxArrayElement)
        {
            maxArrayElement = array[i];
            maxArrayElementIndex = i;
        }
        else if (array[i] < array[i + 1] && maxArrayElement < array[i + 1])
        {
            maxArrayElement = array[i + 1];
            maxArrayElementIndex = i + 1;
        }
        else if (array[i] == array[i + 1])
            elementEqual++;
       
        //Finding max module(abs) of array element
        if (Math.Abs(array[i]) > Math.Abs(array[i + 1]) && Math.Abs(array[i]) > maxArrayElementOnModule)
            maxArrayElementOnModule = Math.Abs(array[i]);
        else if (Math.Abs(array[i]) < Math.Abs(array[i + 1]) && maxArrayElementOnModule < Math.Abs(array[i + 1]))
            maxArrayElementOnModule = Math.Abs(array[i + 1]);
    }

    Console.Write("The input array = ");
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]}; ");
    Console.WriteLine(" ");

    if (sumNegativeElementArray < 0)
        Console.WriteLine($"Sum of negative elements the array = {sumNegativeElementArray} ");
    else
        Console.WriteLine("Negative elements  of the array are absent");

    if (elementEqual == count - 1)
        Console.WriteLine("All array elements are equal each other");
    else
    {
        Console.WriteLine($"Max array element  = {maxArrayElement} ");
        Console.WriteLine($"Max array element index = {maxArrayElementIndex} ");
        Console.WriteLine($"Max module(abs) array element = {maxArrayElementOnModule}");
    }

    if (sumPositiveElementArrayIndex < 0)
        Console.WriteLine("In array absent positive element - no sum of index positive element");
    else
        Console.WriteLine($"Sum of index positive element array = {sumPositiveElementArrayIndex}");

    if (quantityIntegerInArray == 0)
        Console.WriteLine("Integer in array are absent");
    else
        Console.WriteLine($"Quantity integer in array = {quantityIntegerInArray}");
}