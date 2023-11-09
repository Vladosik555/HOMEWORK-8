using System;
using System.Collections.Generic;
using System.IO;

namespace Тумаков
{
    enum BankType
    {
        текущий,
        сберегательный
    }
    internal class Bank_account
    {
        private uint number_count = 1;
        private uint numb_card;
        private uint number;
        Queue<BankTransaction> transactions = new Queue<BankTransaction>();
        private double balance;
        private BankType type;
        private bool dispose = false;
        /// <summary>
        /// генерация уникального номера
        /// </summary>
        public void GeneratNumn()
        {
            number_count++;
        }
        /// <summary>
        /// конструктор для баланса и уникального номера
        /// </summary>
        /// <param name="balance"></param>
        public Bank_account(double balance)
        {
            GeneratNumn();
            number = number_count;
            this.balance = balance;
        }
        /// <summary>
        /// конструктор для типа банка
        /// </summary>
        /// <param name="type"></param>
        public Bank_account(BankType type)
        {
            GeneratNumn();
            number = number_count;
            this.type = type;
        }
        /// <summary>
        /// конструктора для баланса и типа банка
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="type"></param>
        public Bank_account(double balance, BankType type)
        {
            GeneratNumn();
            number = number_count;
            this.balance = balance;
            this.type = type;
        }
        /// <summary>
        /// метод, который позволяет положить деньги на счёт
        /// </summary>
        /// <param name="put_money"></param>
        public void PutMoney(double put_money)
        {
            BankTransaction transaction = new BankTransaction(put_money);
            transactions.Enqueue(transaction);
            balance += put_money;
            Console.WriteLine($"Ваш баланс составляет {balance} рублей");
        }
        /// <summary>
        /// метод, который позваляет снять деньги со счёта
        /// </summary>
        /// <param name="takeoff_money"></param>
        public void TakeoffMoney(double takeoff_money)
        {
            if (takeoff_money <= balance)
            {
                BankTransaction transaction = new BankTransaction(takeoff_money);
                transactions.Enqueue(transaction);
                balance -= takeoff_money;
                Console.WriteLine($"Ваш баланс составляет {balance} рублей");
            }
            else
            {
                Console.WriteLine("Вы не можете снять сумму, которая превышает ваш баланс");
            }
        }
        /// <summary>
        /// метод, который позволяет перевести деньги на другую карту
        /// </summary>
        /// <param name="money"></param>
        /// <param name="numb"></param>
        public void Transfer(double money, uint numb)
        {
            numb_card = numb;
            if (money <= balance)
            {
                BankTransaction transaction = new BankTransaction(money);
                transactions.Enqueue(transaction);
                balance -= money;
                Console.WriteLine($"Вы перевели {money} рублей на номер карты {numb_card}, ваш счёт составляет {balance} рублей");
            }
            else
            {
                Console.WriteLine("Вы не можете перевести сумму, которая превышает ваш баланс");
            }
        }
        /// <summary>
        /// метод, который записывает всю информацию в файл
        /// </summary>
        public void Dispose()
        {
            if (!dispose)
            {
                foreach (BankTransaction transac in transactions)
                {
                    File.WriteAllText("operation.txt", transac.Print_data());
                }
                dispose = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
