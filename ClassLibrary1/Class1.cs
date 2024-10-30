using System;

namespace Lib_1
{
    public class Class1
    {
        private Random random = new Random();

        // Метод для вычисления разницы целых случайных чисел
        public  static void CalculateDifference(int k, out int sum, out string susm, out int count)
        {
            sum = 0;
            count = 0;
            susm = "";
            int lastNumber = 0;
            int difference = int.MaxValue;
            Random random = new Random();

            while (difference >= Math.Abs(k))
            {
                int randomNumber = random.Next(2, 11); // Генерируем случайное число от 2 до 10
                sum += randomNumber;
                count++;
                susm += randomNumber.ToString()+",";
                // Рассчитываем разницу только если у нас есть хотя бы два числа
                if (count > 1)
                {
                    difference = Math.Abs(randomNumber - lastNumber);
                }

                lastNumber = randomNumber;
            }

           
        }
    }
}