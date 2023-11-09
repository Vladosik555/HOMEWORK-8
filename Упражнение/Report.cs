using System;

namespace Упражнение
{
    enum Report_
    {
        текст_отчёта = 12,
        дата_выполнения = 13,
        исполнитель = 14
    }
    internal class Report
    {
        private int count_task;
        Person person;
        public Report(int count_task)
        {
            this.count_task = count_task;
        }
        /// <summary>
        /// метод, который выдаёт отчёт присутствие или отсутствие задачи
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public string ResultReport(Report report)
        {
            if (report.count_task == 1)
            {
                Console.WriteLine($"Отсчёт утвердился успешно, задача принята");
                return "Отсчёт утвердился успешно, задача принята";
            }
            else
            {
                Console.WriteLine($"Задачу нужно отправить на доработку");
                return "Задачу нужно отправить на доработку";
            }
        }/// <summary>
        /// метод, который проверяет наличие задачи у сотрудника
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        public int CountTask(Report report)
        {
            if (report.count_task == 1)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        } 

    }
}
