using System;

namespace Упражнение
{
    enum Status_Project
    {
        Проект = 5,
        Исполнение = 6,
        Закрыт= 7
    }
    internal class Project
    {
        private string description { get; set; }
        private DateTime time { get; set; }
        private string customer { get; set; }
        private Person person { get; set; }
        private Task task { get; set; }
        private Status_Project status { get; set; }

        public Project(string description, DateTime time, string customer, Person person, Status_Project status)
        {
            this.description = description;
            this.time = time;
            this.customer = customer;
            this.person = person;
            this.status = status;
        }
        /// <summary>
        /// метод, который проверяет в каком статусе находиться проект 
        /// </summary>
        /// <returns></returns>
        public Status_Project Сhecking_Project_Status()
        {
            if (status == Status_Project.Проект)
            {
                return Status_Project.Проект;
            }
            else if (status == Status_Project.Исполнение)
            {
                return Status_Project.Исполнение;
            }
            else
            {
                return Status_Project.Закрыт;
            }
        }
    }
}
