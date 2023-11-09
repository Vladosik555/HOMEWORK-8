using System;
using System.Collections.Generic;

namespace Упражнение
{
    enum Persons
    {
        Тимплид = 1,
        Главный_разраб = 2,
        Разраб = 3,
        Художник = 4,

    }
    internal class Person
    {
        private string name;
        private List<Task> tasks = new List<Task>();
        private Persons person;
        private Status_Task Status;
        public Person(string name, Persons person)
        {
            this.name = name;
            this.person = person;
        }
        public Person(string name, Task[] task, Status_Task status)
        {
            this.name = name;
            this.tasks.AddRange(task);
            Status = status;
        }
        /// <summary>
        /// метод, который добавляет задачу сотруднику
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            Console.WriteLine($"{name} взял задачу: (({task.description_}))");
            task.status_ = Status_Task.Назначена;
            tasks.Add(task);
        }
        /// <summary>
        /// метод, который удаляет задачу сотруднику
        /// </summary>
        /// <param name="task"></param>
        public void RemoveTask(Task task)
        {
            Console.WriteLine($"{name} решил отказаться от задачи: (({task.description_}))");
            task.status_ = Status_Task.Не_назначена;
            tasks.Remove(task);
        }
        /// <summary>
        /// метод, который позволяет взять задачу сотрудника, который от неё отказался
        /// </summary>
        /// <param name="task"></param>
        /// <param name="person"></param>
        public void SubmitTask(Task task, Person person)
        {
            Console.WriteLine($"{name} решил взять задачу {person.name}");
            task.status_ = Status_Task.Назначена;
        }
        
    }
}
