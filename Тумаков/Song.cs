using System;

namespace Тумаков
{
    internal class Song
    {
        private string name { get; set; }
        private string author { get; set; }
        public Song prev { get; set; }
        /// <summary>
        /// метод, который возвращает название песни
        /// </summary>
        /// <returns></returns>
        public string FillingName()
        {
            Console.Write("Напишите название песни: ");
            name = Console.ReadLine();
            return name;
        }
        /// <summary>
        /// метод, который возвращает автора
        /// </summary>
        /// <returns></returns>
        public string FillingAuthor()
        {
            Console.Write("Напишите автора песни: ");
            author = Console.ReadLine();
            return author;
        }
        /// <summary>
        /// метод, который позволяет записать название песни и автора
        /// </summary>
        /// <param name="song"></param>
        public void Prev(Song[] song)
        {
            for (int i = 0; i < song.Length; i++)
            {
                song[i].FillingName();
                song[i].FillingAuthor();
                Title();
            }
        }
        /// <summary>
        /// метод, который выводит информацию о названии песни и авторе
        /// </summary>
        public void Title()
        {
            string title = $"название песни: {name}, автор песни: {author}";
            Console.WriteLine(title);
        }
        /// <summary>
        /// метод, который сравнивает песню с предыдущей
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public override bool Equals(object d)
        {
            Song song = d as Song;
            if (song == null && song.name == name && song.author == author)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.prev = null;
        }
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public Song()
        {

        }
    }
}
