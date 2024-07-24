using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    internal class Spectacle :IDisposable
    {
        public string Title { get; set; } = string.Empty;

        public string TheaterName { get; set; } = string.Empty;

        public string Ganre { get; set; } = string.Empty;

        public TimeOnly Duration {  get; set; }


        List<Actor> ActorList = new List<Actor>();

        public Spectacle(string title, string theaterName, string ganre, TimeOnly duration, params Actor[] actors)
        {
            Title = title;
            TheaterName = theaterName;
            Ganre = ganre;
            Duration = duration;
            if(actors is null)
            {
                throw new ArgumentNullException("Actors is null");
            }
            ActorList.AddRange(actors);
        }

        public List<Actor> Actors 
        {  
            get { return ActorList; } 
            set
            {
                if (value is null) { throw new ArgumentNullException("Actors is null"); }
                ActorList = value;
            }
        }

        ~Spectacle()
        {
            Dispose(false);
            Console.WriteLine("Destructor");
        }

        private bool disposed = false;

        public void Dispose()
        {
            Console.WriteLine($"Rip spectacle {Title}");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                ActorList.Clear();
            }
            disposed = true;
        }
    }
}


//Создайте класс Спектакль. Класс должен хранить такую информацию:
//- Название спектакля
//- Название театра
//- Жанр
//- Длительность
//- Список актёров
//Реализуйте в классе методы и свойства, необходимые для функционирования класса.
//Класс должен реализовывать интерфейс IDisposable. Напишите код для тестирования функциональности класса.
//Напишите код для вызова метода Dispose.