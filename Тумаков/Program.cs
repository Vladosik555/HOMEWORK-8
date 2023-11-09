using System;

namespace Тумаков
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 9.1-9.3");
            Console.WriteLine("Банковский аккаунт(работа с конструкторами)");
            Bank_account bank_1 = new Bank_account(10000);
            Bank_account bank_2 = new Bank_account(BankType.текущий);
            Bank_account bank_3 = new Bank_account(10000, BankType.текущий);
            Console.WriteLine($"На вашем {BankType.текущий} счёте {10000} рублей");
            Console.WriteLine("\nВыберите операцию:" + 
                "\nесли желаете положить деньги на счёт, нажмите 1" + 
                "\nесли желаете снять деньги со счёта, нажмите 2" +
                "\nесли желаете перевести деньги на другую карту, нажмите 3");
            bool flag = int.TryParse(Console.ReadLine(), out int operation);
            if (flag)
            {
                switch (operation)
                {
                    case 1:
                        Console.Write("Напишите сумму, которую хотите положить: ");
                        bool flag1 = double.TryParse(Console.ReadLine(), out double put_money);
                        if (flag1)
                        {
                            bank_1.PutMoney(put_money);
                            bank_1.Dispose();
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        break;
                    case 2:
                        Console.Write("Напишите сумму, которую хотите снять: ");
                        bool flag2 = double.TryParse(Console.ReadLine(), out double takeoff_money);
                        if (flag2)
                        {
                            bank_1.TakeoffMoney(takeoff_money);
                            bank_1.Dispose();
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        break;
                    case 3:
                        Console.Write("Напишите сумму, которую хотите перевести на другую карту: ");
                        bool flag3 = double.TryParse(Console.ReadLine(), out double money);
                        Console.Write("Напишите номер карты: ");
                        bool flag4 = uint.TryParse(Console.ReadLine(), out uint numb);
                        if (flag3 && flag4)
                        {
                            bank_1.Transfer(money, numb);
                            bank_1.Dispose();
                        }
                        else
                        {
                            Console.WriteLine("Нельзя вводить отрицательные числа, строки и символы");
                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали команду");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Такой команды не существует");
            }

            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 9.1");
            Console.WriteLine("Работа с песнями");
            Song song_1 = new Song();
            Song song_2 = new Song();
            Song song_3 = new Song();
            Song song_4 = new Song();
            Song[] songs = { song_1, song_2, song_3, song_4 };
            for (int i = 0; i < songs.Length; i++)
            {
                songs[i].FillingName();
                songs[i].FillingAuthor();
                if (i != 0)
                {
                    songs[i].prev = songs[i - 1];
                }
                songs[i].Title();
                if (i != 0)
                {
                    switch (i)
                    {
                        case 1:
                            string num_1 = "первая";
                            string num_2 = "вторая";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num_1} и {num_2} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num_1} и {num_2} это разные песни");
                            }
                            break;
                        case 2:
                            string num2 = "вторая";
                            string num3 = "третья";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num2} и {num3} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num2} и {num3} это разные песни");
                            }
                            break;
                        case 3:
                            string num_3 = "третья";
                            string num_4 = "четверная";
                            if (songs[i].Equals(songs[i - 1]))
                            {
                                Console.WriteLine($"{num_3} и {num_4} это одинаковые песни");
                            }
                            else
                            {
                                Console.WriteLine($"{num_3} и {num_4} это разные песни");
                            }
                            break;
                        default:
                            continue;
                    }
                }
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();

        }
    }
}
