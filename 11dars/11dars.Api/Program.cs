using _11dars.Api.Services;

namespace _11dars.Api;

internal class Program
{
    static void Main(string[] args)
    {

        TestClass test1 = new TestClass(); // 1
        test1.SetValue(50);
        TestClass test2 = new TestClass(); // 2
        TestClass test3 = new TestClass(); // 3
        TestClass test4 = new TestClass(); // 4
        TestClass test5 = new TestClass(); // 5

        

        Console.WriteLine(test5.GetAmount());
        Console.WriteLine(TestClass.CounterObj);





        //Animal.Do1();
        //Animal animal = new Animal();   
        //animal.Do2();

        //CounterNumber obj1 = new CounterNumber();
        //CounterNumber obj2 = new CounterNumber();
        //CounterNumber obj3 = new CounterNumber();

        //obj1.Increment(); // 1 : 1
        //obj1.Increment(); // 2 : 2
        //obj2.Increment(); // 1 : 3
        //obj3.Increment(); // 1 : 4
       

        //Console.WriteLine(obj1.InstanceCount);
        //Console.WriteLine(obj2.InstanceCount);
        //Console.WriteLine(obj3.InstanceCount);

        //Console.WriteLine(CounterNumber.TotalCount); // 4
        
        
    }

    public static void Foo1()
    {

    }

    public void Foo2()
    {
        Foo1();
    }

    



    public static int GetQuentityElementsWithFiveCapitalLetter(List<string> texts)
    {
        var resultCounter = 0;
        foreach (var text in texts)
        {
            var counterCapital = 0;
            foreach(var letter in text)
            {
                if(char.IsUpper(letter) is true)
                {
                    counterCapital++;
                }
            }

            if(counterCapital == 5)
            {
                resultCounter++;
            }
        }

        return resultCounter;
    }

    public static string RemoveSalom(string text)
    {
        if(text.StartsWith("salom") is true)
        {
            text = text.Remove(0, 5);
        }

        return text;
    }




}




