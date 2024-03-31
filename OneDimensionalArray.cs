using System;
using System.Collections;

public sealed class OneDimensionalArray<T>
{
    private Random rnd = new Random();
    private T[] array;
    private int _length;
    private int _size;

    public OneDimensionalArray(int length = 10)
    {
        array = new T[length];
        _length = length;
        _size = 0;
    }

    public void Print()
    {
        Console.WriteLine("Array");
        for (int i = 0; i < _size; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
    }

    public void Add(T element)
    {
        if(_size >= _length)
        {
            _length = 2 * _length + 1;
            T[] mass = new T[_length];
            Array.Copy(array, mass, _size);
            array = mass;
        }
        array[_size] = element;
        _size++;
    }

    public void DeleteElement(int index)
    {
        if(index <= _size)
        {
            T[] arr = new T[_length];
            for (int i = 0; i < _size-1; i++)
            {
                if (i != index)
                {
                    arr[i] = array[i];
                }
                else
                {
                    arr[i] = array[_size-1]; 
                    array[_size-1] = default(T);
                }
            }
            array = arr;
            _size = _size - 1;
        }
        else
        {
            Console.WriteLine("Index is out of range");
            Console.WriteLine(" ");
        }
    }

    public void Sorting()
    {
        Array.Sort(array, 0, _size);
    }

    public void Count_if_and_without_if(Func<T, bool> action = null)
    {
        int count = 0;
        if (action != null)
        {
            for(int i = 0; i<_size; i++)
            {
                if(action(array[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        else
        {
            Console.WriteLine(_size);
        }
    }

    public bool If_One(Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (action(array[i]))
            {
                return true;
            }
        }
        return false;
    }
    public bool If_All(Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (!action(array[i]))
            {
                return false;
            }
        }
        return true;
    }

    public int Index_First_Element_If(Func<T, bool> action)
    {
        for (int i = 0; i < _size; i++)
        {
            if (action(array[i]))
            {
                Console.WriteLine(array[i] + " Return the index of this element");
                return i;
            }
        }
        Console.WriteLine("There is no element satisfying the condition. Return 0");
        return 0;
    }

    public T[] Do_With_Array(Func<T, T> action)
    {
        for (int i = 0; i < _size; i++)
        {
            array[i] = action(array[i]);
        }
        return array;
    }

    public void Get_All_Elements_If(Func<T, bool> action)
    {
        int c = 0;
        for (int i = 0; i < _size; i++)
        {
            if (action(array[i]))
            {
                Console.Write(array[i] + " ");
                c = 1;
            }
        }
        if (c != 1)
        { Console.WriteLine("There is no element satisfying the condition."); }
    }

    public void Print_Reverse()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Reverse array");
        for (int i = _size-1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
    }

    public void Get_From_Index_To_Index(int start, int number)
    {
        Console.WriteLine("From index " + start + " " + number + " elements");
        if (start + number + 1 < _length)
        {
            for (int i = start; i < start + number + 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("Index is out of range");
            Console.WriteLine(" ");
        }
    }
}
