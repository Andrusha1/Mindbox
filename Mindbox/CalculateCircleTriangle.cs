namespace Mindbox;
public class CalculateAreas
{
    public int CalculateArea(int a)
    {
        int result = (int) Math.PI * (a * a);
        return result;
    }

    public int CalculateArea(int a, int b, int c)
    {
        int p = (a + b + c) / 2; //Полупериметр треугольника
        int result = (int) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return result;
    }
}

