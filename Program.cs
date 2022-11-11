using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Итрерфейс
        /// </summary>
        public interface IGun
        {
            int damage { get; set; } // свойство урона
            void Shoot(); // метод выстрела
        }
        /// <summary>
        /// Пистолет
        /// </summary>
        public class Pistol : IGun
        {
            public int damage { get; set; } 
            public void Shoot()
            {
                Console.WriteLine("Стреляет пистолетом " + damage + " ед урона"); // опишем логику выстрела
            }
        }
        /// <summary>
        /// пулемет
        /// </summary>
        public class MachineGun : IGun
        {
            public int damage { get; set; }
            public void Shoot()
            {
                Console.WriteLine("Стреляет автоматом и наносит " + damage + " ед урона"); // опишем логику выстрела
            }
        }
        /// <summary>
        ///  персонаж
        /// </summary>
        public class Hero
        {
            public string Name { get; set; } // имя персонажа
            public IGun Gun { private get; set; } // его оружие

            public Hero(string name, IGun gun)
            {
                Name = name;
                Gun = gun;
            }

            public void Shoot() // стрельба
            {
                Console.Write(Name + " ");
                Gun.Shoot();
            }
        }
        static void Main(string[] args)
        {
            Hero hero = new Hero("Воин", new MachineGun() { damage = 1}); // создаим персонажа 
            hero.Shoot();
            hero.Gun = new Pistol() { damage = 10};
            hero.Shoot();
            Console.ReadKey();
        }
    }
}
