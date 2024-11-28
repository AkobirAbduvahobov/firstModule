namespace _11dars.Api;

public class TestClass
{
    public string Name { get; set; }

    public static int CounterObj = 0;

    public TestClass()
    {
        CounterObj++;
    }

    public int GetAmount()
    {
        return CounterObj;
    }

    public void SetValue(int value)
    {
        CounterObj = value;
    }
}
