using System;

namespace Тумаков
{
    internal class BankTransaction
    {
        private readonly double sum;
        private DateTime date;
        /// <summary>
        /// конструктор для суммы и даты
        /// </summary>
        /// <param name="sum"></param>
        public BankTransaction(double sum)
        {
            this.sum = sum;
            this.date = DateTime.Now;
        }
        /// <summary>
        /// Возвращает информацию об операции
        /// </summary>
        /// <returns></returns>
        public string Print_data()
        {
            string infor = $"Операция на сумму {sum} произошла в {date}";
            Console.WriteLine($"Операция на сумму {sum} произошла в {date}");
            return infor;
        }
    }
}
