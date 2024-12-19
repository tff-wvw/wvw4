using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер задания 1-39");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 1");
                        Console.WriteLine("Введите первое число: ");

                        int a, b, result = 0;
                        while (!int.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Введите корректное число");
                            Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine("Введите первое число: ");
                        }

                        Console.WriteLine("Введите второе число: ");

                        while (!int.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Введите корректное число");
                            Thread.Sleep(1500);
                            Console.Clear();
                            Console.WriteLine("Введите второе число: ");
                        }

                        Console.WriteLine("Введите символ действия");

                        switch(Console.ReadLine())
                        {
                            case "+":
                                result = a + b;                               
                                break;
                            case "-":
                                result = a - b;
                                Console.WriteLine($"Результат равен {result}");
                                break;
                            case "*":
                                result = a * b;
                                Console.WriteLine($"Результат равен {result}");
                                break;
                            case "/":
                                result = a / b;
                                Console.WriteLine($"Результат равен {result}");
                                break;
                            default:
                                Console.WriteLine("Некорректное действие");

                                break;
                        }

                        Console.ReadKey();
                    }

                        
                    break;
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 2");
                        Console.WriteLine("Ведите номер дня недели: ");



                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "понедельник";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "2":
                                name = "вторник";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "3":
                                name = "среда";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "4":
                                name = "четверг";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "5":
                                name = "пятница";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "6":
                                name = "суббота";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "7":
                                name = "воскресенье";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверный номер дня недели");
                                break;
                        }
                        Console.ReadKey();
                    }


                    break;
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 5");
                        Console.WriteLine("Ведите оценку: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "A":
                                name = "5";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "B":
                                name = "4";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "C":
                                name = "3";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "D":
                                name = "2";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "F":
                                name = "1";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверная оценка");
                                break;
                        }

                        Console.ReadKey (); 
                    }
                    break;
                case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 4");
                            Console.WriteLine("Ведите цифру месяца: ");



                            string name = "";


                            switch (Console.ReadLine())
                            {
                                case "1":
                                    name = "январь - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "2":
                                    name = "февраль - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "3":
                                    name = "март - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "4":
                                    name = "апрель - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "5":
                                    name = "май - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "6":
                                    name = "июнь - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "7":
                                    name = "июль - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "8":
                                    name = "август - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "9":
                                    name = "сентябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "10":
                                    name = "октябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "11":
                                    name = "ноябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "12":
                                    name = "декабрь - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная цифра месяца");
                                    break;
                            }
                            Console.ReadKey();
                        }
                    break;
                case "5":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 5");
                        Console.WriteLine("Ведите цвет: ");



                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "красный":
                                name = "стой";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "Красный":
                                name = "стой";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "желтый":
                                name = "приготовься";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "Желтый":
                                name = "приготовься";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "жёлтый":
                                name = "приготовься";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "Жёлтый":
                                name = "приготовься";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "зеленый":
                                name = "проезд разрешен";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "Зеленый":
                                name = "проезд разрешен";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "зелёный":
                                name = "проезд разрешен";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            case "Зелёный":
                                name = "проезд разрешен";
                                Console.WriteLine($"Этот цвет значит {name}.");
                                break;
                            default:
                                Console.WriteLine("неверный цвет");
                                break;
                        }
                        Console.ReadKey();
                    }

                    break;
                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 6");
                        Console.WriteLine("Ведите уровень доступа: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "guest":
                                name = "ограниченые права";
                                Console.WriteLine($"Этот уровень доступа значит что у вас {name}.");
                                break;
                            case "user":
                                name = "стандартные права";
                                Console.WriteLine($"Этот уровень доступа значит что у вас {name}.");
                                break;
                            case "admin":
                                name = "полные права";
                                Console.WriteLine($"Этот уровень доступа значит что у вас {name}.");
                                break;
                            default:
                                Console.WriteLine("неверный уровень доступа");
                                break;
                        }

                        Console.ReadKey();
                    }

                    break;
                case "7":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 7");
                        Console.WriteLine("Ведите название фрукта: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "яблоко":
                                name = "красный или зеленый";
                                Console.WriteLine($"Цвет этого фрукта {name}.");
                                break;
                            case "банан":
                                name = "желтый";
                                Console.WriteLine($"Цвет этого фрукта {name}.");
                                break;
                            case "апельсин":
                                name = "оранжевый";
                                Console.WriteLine($"Цвет этого фрукта {name}.");
                                break;
                            default:
                                Console.WriteLine("неверное название фрукта");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "8":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 8");
                        Console.WriteLine("Ведите название страны: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "Россия":
                                name = "город Москва";
                                Console.WriteLine($"Столица этой страны {name}.");
                                break;
                            case "США":
                                name = "штат Вашингтон";
                                Console.WriteLine($"Столица этой страны {name}.");
                                break;
                            case "Франция":
                                name = "город Париж";
                                Console.WriteLine($"Столица этой страны {name}.");
                                break;
                            default:
                                Console.WriteLine("неверное название страны");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 9");
                        Console.WriteLine("Ведите номер сезона: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "Весна";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "2":
                                name = "Лето";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "3":
                                name = "Осень";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "4":
                                name = "Зима";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "10":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 9");
                        Console.WriteLine("Ведите название животного: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "картофель":
                                name = "ничего не делает";
                                Console.WriteLine($"Это животное {name}.");
                                break;
                            case "кот":
                                name = "мяукает";
                                Console.WriteLine($"Это животное {name}.");
                                break;
                            case "собака":
                                name = "гавкает";
                                Console.WriteLine($"Это животное {name}.");
                                break;
                            case "крокодил":
                                name = "кусается";
                                Console.WriteLine($"Это животное {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "11":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 9");
                        Console.WriteLine("Ведите количество сторон: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "круг";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "2":
                                name = "угол";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "3":
                                name = "треугольник";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "4":
                                name = "четырехугольник";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "12":
                    break;
                case "13":
                    break;
                case "14":
                    break;
                case "15":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 15");
                        Console.WriteLine("Введите количество денег в рублях: ");

                        double a, result1 = 0;
                        while (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Введите корректное число!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Введите количество денег в рублях: ");
                        }

                        Console.WriteLine("Выберите номер валюты для перевода (доллар - 1, евро - 2, тенге - 3 )");
                        char val = (char)Console.Read();

                        switch (val)
                        {
                            case '1':
                                result1 = a / 100;
                                Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                break;
                            case '2':
                                result1 = a / 101;
                                Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                break;
                            case '3':
                                result1 = a / 0.2;
                                Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                break;
                            default:
                                Console.WriteLine("неверный номер");
                                break;
                        }

                        Thread.Sleep(5000);
                    }
                    break;
                case "16":
                    break;
                case "17":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 17");
                        Console.WriteLine("Ведите коод состояния HTTP: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "200":
                                name = "успешный запрос";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "404":
                                name = "неизвестная ошибка";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "500":
                                name = "ошибка";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "18":
                    break;
                case "19":
                    break;
                case "20":
                    break;
                case "21":
                    break;
                case "22":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 22");
                        Console.WriteLine("Введите номер напитка: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "чай";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "2":
                                name = "сок";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "3":
                                name = "кофе";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "23":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 23");
                        Console.WriteLine("Введите тип транспорта: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "легковой":
                                name = "быстрый";
                                Console.WriteLine($"Характеристика этого транспорта {name}.");
                                break;
                            case "грузовой":
                                name = "большой";
                                Console.WriteLine($"Характеристика этого транспорта {name}.");
                                break;
                            case "автобус":
                                name = "многометный";
                                Console.WriteLine($"Характеристика этого транспорта {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }

                    break;
                case "24":
                    break;
                case "25":
                    break;
                case "26":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 26");
                        Console.WriteLine("Введите код цвета RGB: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "R":
                                name = "красный";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "G":
                                name = "зеленый";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "B":
                                name = "синий";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "27":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 27");
                        Console.WriteLine("Введите номер блюда: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "салат";
                                Console.WriteLine($"Это {name} и он малоколорийный.");
                                break;
                            case "2":
                                name = "пицца";
                                Console.WriteLine($"Это {name} и она очень вкусная.");
                                break;
                            case "3":
                                name = "паста";
                                Console.WriteLine($"Это {name} и она очень сытная.");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "28":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 28");
                        Console.WriteLine("Введите тип файла: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "txt":
                                name = "текст";
                                Console.WriteLine($"Это {name} .");
                                break;
                            case "jpg":
                                name = "изображение";
                                Console.WriteLine($"Это {name} .");
                                break;
                            case "mp3":
                                name = "аудиофайл";
                                Console.WriteLine($"Это {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "29":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 29");
                        Console.WriteLine("Введите оценку товара от 1 до 5: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "очень плохого";
                                Console.WriteLine($"Товар {name} качества .");
                                break;
                            case "2":
                                name = "плохого";
                                Console.WriteLine($"Товар {name} качества .");
                                break;
                            case "3":
                                name = "среднего";
                                Console.WriteLine($"Товар {name} качества .");
                                break;
                            case "4":
                                name = "хорошего";
                                Console.WriteLine($"Товар {name} качества .");
                                break;
                            case "5":
                                name = "отличного";
                                Console.WriteLine($"Товар {name} качества .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "30":                 
                    break;
                case "31":
                    break;
                case "32":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 32");
                        Console.WriteLine("Введите номер языка 1-Русский 2-Английскийй 3-Французкий: ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "Привет";
                                Console.WriteLine($"Приветсвие на этом языке звучит как {name} .");
                                break;
                            case "2":
                                name = "Hello";
                                Console.WriteLine($"Приветсвие на этом языке звучит как {name} .");
                                break;
                            case "3":
                                name = "Bonjour";
                                Console.WriteLine($"Приветсвие на этом языке звучит как {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "33":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 33");
                        Console.WriteLine("Введите название вида : ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "млекопитающие":
                                name = "кормит дедей молоком";
                                Console.WriteLine($"Этот вид {name} .");
                                break;
                            case "птица":
                                name = "умеет летать";
                                Console.WriteLine($"Этот вид {name} .");
                                break;
                            case "рептилия":
                                name = "имеет чешую";
                                Console.WriteLine($"Этот вид {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }

                    break;
                case "34":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 34");
                        Console.WriteLine("Введите номер образования : ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "школу";
                                Console.WriteLine($"Этот вид образования значит что человек закончил  {name} .");
                                break;
                            case "2":
                                name = "коллежд";
                                Console.WriteLine($"Этот вид {name} .");
                                break;
                            case "3":
                                name = "ВУЗ";
                                Console.WriteLine($"Этот вид {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "35":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 35");
                        Console.WriteLine("Введите что-то в строку : ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "":
                                name = "ничего не содержит";
                                Console.WriteLine($"Строка  {name} .");
                                break;
                            default:
                                name = "содержит сомволы";
                                Console.WriteLine($"Строка  {name} .");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "36":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 36");
                        Console.WriteLine("Введите жанр фильма : ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "хоррор":
                                name = "происходят ужасные события";
                                Console.WriteLine($"В этом фильме  {name} .");
                                break;
                            case "боевик":
                                name = "много экшона";
                                Console.WriteLine($"В этом фильме  {name} .");
                                break;
                            case "драмма":
                                name = "происходять драмматические события";
                                Console.WriteLine($"В этом фильме  {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "37":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 37");
                        Console.WriteLine("Введите код валюты : ");

                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "USD":
                                name = "доллары";
                                Console.WriteLine($"Это  {name} .");
                                break;
                            case "RUB":
                                name = "рубли";
                                Console.WriteLine($"Это  {name} .");
                                break;
                            case "EUR":
                                name = "евро";
                                Console.WriteLine($"Это  {name} .");
                                break;
                            default:
                                Console.WriteLine("неверные данные");
                                break;
                        }

                        Console.ReadKey();
                    }
                    break;
                case "38":
                    break;
                case "39":
                    {
                        Console.Clear();
                        Console.WriteLine("Задание 39");
                        Console.WriteLine("Ведите цифру месяца: ");



                        string name = "";


                        switch (Console.ReadLine())
                        {
                            case "1":
                                name = "январь - зима";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "2":
                                name = "февраль - зима";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "3":
                                name = "март - весна";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "4":
                                name = "апрель - весна";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "5":
                                name = "май - весна";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "6":
                                name = "июнь - лето";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "7":
                                name = "июль - лето";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "8":
                                name = "август - лето";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "9":
                                name = "сентябрь - осень";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "10":
                                name = "октябрь - осень";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "11":
                                name = "ноябрь - осень";
                                Console.WriteLine($"Это {name}.");
                                break;
                            case "12":
                                name = "декабрь - зима";
                                Console.WriteLine($"Это {name}.");
                                break;
                            default:
                                Console.WriteLine("неверная цифра месяца");
                                break;
                        }
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("Неверный е=номер задания");
                    break;

            }




        }
    }
}
