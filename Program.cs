using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_na_kanikuly
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Zadaca 1
            // Вопрос и варианты ответа
            string question = "Какой сегодня день недели?";
            string[] options = { "Понедельник", "Среда", "Пятница" };
            string correctAnswer = options[0];

            // Выводим вопрос и варианты ответа
            Console.WriteLine(question);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            // Получаем ответ от пользователя
            Console.Write("Введите номер вашего ответа: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

            // Проверяем ответ пользователя
            if (options[userAnswer] == correctAnswer)
            {
                Console.WriteLine("Ваш ответ правильный!");
            }
            else
            {
                Console.WriteLine($"Ваш ответ неправильный. Правильный ответ: {correctAnswer}");
            }
            /////Zadaca2
            // Стоимость переговоров в минуту
            double costPerMinute = 1.0;

            // Вводим продолжительность разговора
            Console.Write("Введите продолжительность разговора в минутах: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            // Вводим день недели
            Console.Write("Введите день недели (цифра от 1 до 7): ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            // Вычисляем стоимость переговоров
            double totalCost = duration * costPerMinute;

            // Если это суббота или воскресенье, предоставляем 20% скидку
            if (dayOfWeek == 6 || dayOfWeek == 7)
            {
                totalCost *= 0.8;
            }

            Console.WriteLine($"Стоимость переговоров: {totalCost} рублей");
            ///zadaca3
            // Получаем текущее время
            int hour = DateTime.Now.Hour;

            // Определяем время суток
            string timeOfDay;
            if (hour >= 6 && hour < 12)
            {
                timeOfDay = "утро";
            }
            else if (hour >= 12 && hour < 18)
            {
                timeOfDay = "день";
            }
            else if (hour >= 18 && hour < 24)
            {
                timeOfDay = "вечер";
            }
            else
            {
                timeOfDay = "ночь";
            }

            // Выводим сообщение
            Console.WriteLine($"Сейчас {timeOfDay}.");
            ///zadaca4
            // Вводим средний балл диплома
            Console.Write("Введите средний балл диплома (от 3 до 5): ");
            double averageScore = Convert.ToDouble(Console.ReadLine());

            // Вводим стаж работы
            Console.Write("Введите стаж работы (0 - нет стажа, 1 - меньше 2 лет, 2 - от 2 до 5 лет): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            // Определяем коэффициент стажа работы
            double experienceCoefficient;
            switch (experience)
            {
                case 0:
                    experienceCoefficient = 1;
                    break;
                case 1:
                    experienceCoefficient = 13;
                    break;
                case 2:
                    experienceCoefficient = 16;
                    break;
                default:
                    Console.WriteLine("Неверный ввод стажа работы.");
                    return;
            }

            // Вычисляем рейтинг
            double rating = averageScore * experienceCoefficient;

            // Выводим сообщение о приеме в магистратуру
            if (rating >= 45)
            {
                Console.WriteLine("Поздравляем! Вы приняты в магистратуру.");
            }
            else
            {
                Console.WriteLine("К сожалению, вам не удалось поступить в магистратуру.");
            }
            ///zadaca5
            // Вводим день и месяц рождения
            Console.Write("Введите день рождения: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения: ");
            int month = Convert.ToInt32(Console.ReadLine());

            // Определяем знак Зодиака
            string zodiacSign;
            if ((month == 3 && day >= 22) || (month == 4 && day <= 21))
            {
                zodiacSign = "Овен";
            }
            else if ((month == 4 && day >= 22) || (month == 5 && day <= 21))
            {
                zodiacSign = "Телец";
            }
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
            {
                zodiacSign = "Близнецы";
            }
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 21))
            {
                zodiacSign = "Рак";
            }
            else if ((month == 7 && day >= 22) || (month == 8 && day <= 21))
            {
                zodiacSign = "Лев";
            }
            else if ((month == 8 && day >= 22) || (month == 9 && day <= 21))
            {
                zodiacSign = "Дева";
            }
            else if ((month == 9 && day >= 22) || (month == 10 && day <= 21))
            {
                zodiacSign = "Весы";
            }
            else if ((month == 10 && day >= 22) || (month == 11 && day <= 21))
            {
                zodiacSign = "Скорпион";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                zodiacSign = "Стрелец";
            }
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 21))
            {
                zodiacSign = "Козерог";
            }
            else if ((month == 1 && day >= 22) || (month == 2 && day <= 21))
            {
                zodiacSign = "Водолей";
            }
            else
            {
                zodiacSign = "Рыбы";
            }

            // Выводим знак Зодиака
            Console.WriteLine($"Ваш знак Зодиака: {zodiacSign}.");
            ///zadaca6
            // Вводим число
            Console.Write("Введите число от 1 до 99: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Определяем правильную форму слова "копейка"
            string word;
            if (number % 10 == 1 && number % 100 != 11)
            {
                word = "копейка";
            }
            else if (number % 10 >= 2 && number % 10 <= 4 && (number % 100 < 10 || number % 100 >= 20))
            {
                word = "копейки";
            }
            else
            {
                word = "копеек";
            }

            // Выводим результат
            Console.WriteLine($"{number} {word}");
            ///zadaca7
            // Вводим число
            Console.Write("Введите число от 1 до 99: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Определяем правильную форму слова "рубль"
            string word1;
            if (number1 % 10 == 1 && number1 % 100 != 11)
            {
                word1 = "рубль";
            }
            else if (number1 % 10 >= 2 && number1 % 10 <= 4 && (number1 % 100 < 10 || number1 % 100 >= 20))
            {
                word1 = "рубля";
            }
            else
            {
                word1 = "рублей";
            }

            // Выводим результат
            Console.WriteLine($"{number1} {word1}");
        }
    }
}
