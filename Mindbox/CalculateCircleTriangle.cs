namespace Mindbox;
public class CalculateAreas
{
    public double CalculateArea(int r)
    {
        double result = Math.PI * (r * r); //Нахождение площади круга
        return Math.Round(result, 2); //Возвращение результата с округлением до 2-х знаков после запятой
    }

    public double CalculateArea(int a, int b, int c)
    {
        double p = (double) (a + b + c) / 2; //Полупериметр треугольника
        double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Результат нахождения площади треугольника
        if ((a * a) + (b * b) == (c * c)) //Проверка на прямоугольный треугольник
        {
            Console.WriteLine("Треугольник является прямоугольным");
        }
        return Math.Round(result, 2); //Возвращение результата с округлением до 2-х знаков после запятой
    }
}