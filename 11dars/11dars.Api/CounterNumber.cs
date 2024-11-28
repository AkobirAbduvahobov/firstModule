namespace _11dars.Api;

public class CounterNumber
{
    public static int TotalCount = 0; 
    public int InstanceCount = 0;    

    public void Increment()
    {
        TotalCount++;    
        InstanceCount++; 
    }
}
