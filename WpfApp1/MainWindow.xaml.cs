using System;
using System.Windows;
using Lib_1;


namespace RandomNumberDifferenceApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем приложение
            Close ();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            // Инфа о программе
            MessageBox.Show("Разработчик: [Баукин Алексей Алексеевич]\nНомер работы: [#1]\nЗадание:Вычислить разницу целых случайных чисел, распределенных в диапазоне от 2 до\r\n10, пока эта разница не станет меньше некоторого числа K (K<0). Вывести на экран\r\nсгенерированные числа, значение суммы, и количество сгенерированных чисел.", "О программе");
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка ввода на корректность
            if (!int.TryParse(KInput.Text, out int k) || k >= 0)
            {
                MessageBox.Show("Пожалуйста, введите значение K, меньше 0.", "Ошибка");
                return;
            }

            //  Для расчета из библиотеки
          
           Class1.CalculateDifference(k,out int d , out string ss , out int dd);

            // Вывод результата 
            ResultTextBlock.Text = $"Сгенерированные числа: {string.Join(",", ss)}\nСумма: {d}\nКоличество сгенерированных чисел: {dd}";
        }
    }
}