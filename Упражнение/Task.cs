using System;

namespace Упражнение
{
    enum Status_Task
    {
        Назначена = 8,
        В_работе = 9,
        На_проверке = 10,
        Выполнена = 11,
        Не_назначена
    }
    internal class Task
    {
        internal string description_ { get; set; }
        private DateTime time { get; set; }
        private string customer_ { get; set; }
        private string executor_ { get; set; }
        public Status_Task status_ { get; set; }

        private Project project { get; set; }

        public Task(string description_, DateTime time, string customer_, string executor_, Status_Task status_)
        {
            this.description_ = description_;
            this.time = time;
            this.customer_ = customer_;
            this.executor_ = executor_;
            this.status_ = status_;
        }
        public Task(string description_, DateTime time, string customer_, Status_Task status_)
        {
            this.description_ = description_;
            this.time = time;
            this.customer_ = customer_;
            this.executor_ = executor_;
            this.status_ = status_;
        }
        /// <summary>
        /// метод, который присваивает задаче статус (В_работе) если она присутствует
        /// </summary>
        /// <param name="task"></param>
        public void StartTask(Task task)
        {
            if(task.status_ == Status_Task.Назначена)
            {
                Console.WriteLine($"Задача (({task.description_})) перешла в статус <В работе>");
                task.status_ = Status_Task.В_работе;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_})) не перешла в статус <В работе>, так как её не выбрали");
            }
        }
        /// <summary>
        /// метод, который присваивает задаче статус (На проверке), если ранее задача находилась в статусе (В_работе)
        /// </summary>
        /// <param name="task"></param>
        public void ExaminationTask(Task task)
        {
            if(task.status_ == Status_Task.В_работе)
            {
                Console.WriteLine($"Задача (({task.description_})) перешла с статус <На проверке>");
                task.status_ = Status_Task.На_проверке;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_})) не перешла в статус <На проверке>, так как её не выбрали");
            }
        }
        /// <summary>
        /// метод, который проверяет соответствует ли задача требованиям
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public int Report(Task task)
        {
            DateTime date = new DateTime(2023, 11, 20);
            if(task.status_ == Status_Task.На_проверке && task.time <= date)
            {
                Console.WriteLine($"Задача (({task.description_})) соответствует требованиям");
                return 1;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_} не соответствует требованиям))");
                return 0;
            }
        }
    }
}
