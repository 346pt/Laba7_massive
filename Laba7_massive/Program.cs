class Progmram
{
    static void Main()
    {
        Massiv<int> intMassiv = new Massiv<int>(4);
        intMassiv.AddData(0,1);
        intMassiv.AddData(1, 3);
        intMassiv.AddData(2, 10);
        intMassiv.AddData(3, 11);
        intMassiv.RemoveData(2);
        intMassiv.GetData(3);
        intMassiv.GetLength();

        Console.WriteLine($"Длина массива {intMassiv.GetLength()}");
        Console.WriteLine($"Первый элемент массива {intMassiv.GetData(2)}");

        Massiv<double> doubleMassiv = new Massiv<double>(2);
        doubleMassiv.AddData(0,1);
        doubleMassiv.AddData(1, 2.5);
        Console.WriteLine($"Длина массива {doubleMassiv.GetLength()}");
        Console.WriteLine($"Первый элемент массива {doubleMassiv.GetData(0)}");
        

        Massiv<string> stringMassiv = new Massiv<string>(2);
        stringMassiv.AddData(0,"Run it up");
        stringMassiv.AddData(1, "Turn up");
        Console.WriteLine($"Второй элемент массива {stringMassiv.GetData(1)}");
        Console.WriteLine("Строчный массив:");
        for (int i = 0; i < stringMassiv.length; i++)
        {
            Console.WriteLine(stringMassiv.GetData(i));
        }
    }
}
class Massiv<T>
{
    public T[] array;
    public int length;

    public Massiv(int size)
    {
        array = new T[size];
        length = size;
    }
    public void AddData(int index, T element)
    {
        if (index >= 0 && index < length)
        {
            array[index] = element;
        }
        else
        {
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    public void RemoveData(int index)
    {
        if (index < 0 || index >= length)
        {
            Console.WriteLine("Недопустимый индекс.");
        }

        for (int i = index; i < length - 1; i++)
        {
           array[i] = array[i + 1];
        }
        length--;
    }

    public T GetData(int index)
    {
        if (index >= 0 && index < length)
        {
            return array[index];
        }
        Console.WriteLine("Недопустимый индекс.");
        return default(T);

    }

    public int GetLength()
    {
        return length;
    }
}

