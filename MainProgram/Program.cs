using Mindbox;

namespace MainProgram
{
    class MainProgram
    {
        public static void Main()
        {
            CalculateAreas calc = new CalculateAreas();
            Procedure proc = new Procedure();

            Console.WriteLine("Поочередно введите исходные данные (если данных больше нет, оставтье поле пустым): ");

            int a = proc.getNum();
            int b = proc.getNum();
            if(b != 0)
            {
                int c = proc.getNum();
                Console.WriteLine(calc.CalculateArea(a, b, c));

                if ((a * a) + (b * b) == (c * c))
                {
                    Console.WriteLine("Треугольник является прямоугольным");
                }
            }
            else
            {
                Console.WriteLine("Площадь круга = " + calc.CalculateArea(a));
            }


        }
    }

    public class Procedure
    {

        public int getNum()
        {
            bool isNum = false;
            int n = 0;
            while (isNum == false)
            {
                var input = Console.ReadLine();
                int.TryParse(input, out n);
                if (n == 0 && input != "")
                {
                    Console.WriteLine("Веденные данные должны быть числом.");
                }
                else
                {
                    isNum = true;
                }
            }
            return n;
        }
    }
}