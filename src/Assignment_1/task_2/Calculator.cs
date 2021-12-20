namespace task_2;

public static class Calculator
{
    public static double average(double a, double b)
    {
        return (a + b) / 2;
    }
    public static double average(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
    public static double average(double[] arr)
    {
        // ------  not using build in method  --------
        // return arr.Average(); 

        int l = arr.Length;
        double x = 0;

        for (int i = 0; i < l; i++)
        {
            x += arr[i];
        }

        return x / l;
    }

}