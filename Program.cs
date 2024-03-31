using System;
using System.Linq.Expressions;
class Progam
{
    static void Main()
    {
        OneDimensionalArray<int> intArray = new();
        intArray.Add(5);
        intArray.Add(209);
        intArray.Add(17);
        intArray.Add(1);
        intArray.Print();
        intArray.DeleteElement(2);
        intArray.Print();
        intArray.Sorting();
        intArray.Print();

        OneDimensionalArray<string> stringArray = new(5);
        stringArray.Add("String");
        stringArray.Add("Nope");
        stringArray.Add("YES");
        stringArray.Print();
        stringArray.Sorting();
        stringArray.Print();
        stringArray.DeleteElement(1);
        stringArray.Print();

        OneDimensionalArray<double> doubleArray = new();
        doubleArray.Print();
        doubleArray.Add(6.4);
        doubleArray.Print();
        doubleArray.DeleteElement(4);
        doubleArray.Print();
        doubleArray.Sorting();
        doubleArray.Print();

        // intArray.Count_if_and_without_if((x)=>
        // {
        //     if (x % 2 == 0)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // });

        // intArray.Count_if_and_without_if();

        // doubleArray.Count_if_and_without_if((x) =>
        // {
        //     if (x > -12.356)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // });

        // Console.WriteLine(intArray.If_One((x)=>
        // {
        //     if (x < 10)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }));
        
        // Console.WriteLine(intArray.If_All((x) => 
        // { 
        //     if (x > 10) 
        //     { 
        //         return true; 
        //     } 
        //     else 
        //     { 
        //         return false; 
        //     } 
        // }));

        // int N = intArray.Index_First_Element_If((x) => 
        // { 
        //     if (x > 1000) 
        //     { 
        //         return true; 
        //     } 
        //     else 
        //     { 
        //         return false; 
        //     } 
        // });
        
        // Console.WriteLine(intArray.If_One((x)=>
        // {
        //     if (x == 5)
        //     {
        //         Console.WriteLine("This element is in the array");
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }));
    
        // intArray.Do_With_Array((x) =>
        // {
        //     return x*2;
        // });
        // intArray.Print();

        // stringArray.Do_With_Array((x) =>
        // {
        //     return x + " slovo";
        // });
        // stringArray.Print();
    
        // intArray.Get_All_Elements_If((x) =>
        // {
        //     if (x % 2 == 0)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // });
    
        // intArray.Print_Reverse();

        // intArray.Get_From_Index_To_Index(2, 5);

    }
}