namespace Week4_Assignment;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    // using OUT parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Manish Puri";  // replace with your full name
    }

    // using PARAMS parameter
    public int SumAll(params int[] numbers)
    {
        return numbers.Sum();
    }
}