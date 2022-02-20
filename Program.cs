using System;
using System.Collections.Generic;
using System.Text;

namespace tekstquestconsol
{
    class Program
    {
        static void Main(string[] args)

        {
            int a;
            bool no = true;
            string name;
            string weapon = "";
            string classofch = "";
            List<Character> characterslist = new List<Character>();
            
            Console.WriteLine("- Привет, незнакомец!");
            Console.WriteLine("");
            Console.WriteLine("- Ты готов начать свой путь?");
            do
            {
                Console.WriteLine("1. Да");
                if (no) Console.WriteLine("2. Нет");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Отлично! Начнем.");
                }
                else if (a == 2 && no)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Подумай хорошенько. Ты готов?");
                    no = false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Я тебя не понимаю. Ты готов приступить?");
                }
            } while (a != 1);
            Console.WriteLine("");
            Console.WriteLine("- Но для начала давай познакомимся поближе! Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("- Приятно познакомиться, " + name + "! Я давно ждал кого-то, подобного тебе!");
            Console.WriteLine("");
            Console.WriteLine("- Что это у тебя в руке?");
            do
            {
                Console.WriteLine("1. Двурукий меч");
                Console.WriteLine("2. Посох из черного дерева");
                Console.WriteLine("3. Лук с крепчайшей тетевой");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    weapon = "двурукий меч";
                    Console.WriteLine("");
                    Console.WriteLine("- Прекрасное оружие! Давно я не видел столь тонкой работы!");
                }
                else if (a == 2)
                {
                    weapon = "посох из черного дерева";
                    Console.WriteLine("");
                    Console.WriteLine("- Прекрасное оружие! Давно я не видел столь тонкой работы!");
                }
                else if (a == 3)
                {
                    weapon = "лук с крепчайшей тетевой";
                    Console.WriteLine("");
                    Console.WriteLine("- Прекрасное оружие! Давно я не видел столь тонкой работы!");
                }
                else
                {
                    Console.WriteLine("- Я тебя не понимаю. Что это такое?");
                }
            } while (a != 1 ^ a != 2 ^ a != 3);
            Console.WriteLine("");
            Console.WriteLine("- Надеюсь, ты простишь меня за мое любопытство, но я не могу понять из каких ты краев! Кто ты?");
            do
            {
                Console.WriteLine("1. Я человек");
                Console.WriteLine("2. Я маг");
                Console.WriteLine("3. Я эльф");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Человек! Давно я не видел ваших в здешних краях.");
                    Human human = new Human(name, weapon);
                    characterslist.Insert(0, human);
                    classofch = "человек";
                }
                else if (a == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Мммм, в наши дни встретить Мага - большая удача!");
                    Mag mag = new Mag(name, weapon);
                    characterslist.Insert(0, mag);
                    classofch = "маг";
                }
                else if (a == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Для меня большое счастье приветсвовать представителя столь древней крови!");
                    Elf elf = new Elf(name, weapon);
                    characterslist.Insert(0, elf);
                    classofch = "эльф";
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Прости, не расслышал. Что ты сказал?");
                }
            } while (a != 1 ^ a != 2 ^ a != 3);
            Character character = characterslist[0];
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу, чтобы продолжить >");
            Console.ReadLine();
            Console.WriteLine($"- Ну что ж, {name}, ты - {classofch}, твое оружие - {weapon}, а твоя специальная способность - {character.get_power()} и у тебя {character.get_lives()} жизней. Теперь и я готов к приключениям с тобой!");
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("- Смотри, перед нами на выбор 2 дороги. Готов ли ты пойти по правой дороге?... А знаешь что, давай отдадим решение случаю!");
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("- Смотри-ка, нам выпала правая, как я и предлагал!! Видимо я все-такие имею какое-то влияние на решение ;)");
            Console.WriteLine("");

                Console.WriteLine("1. Да не может такого быть, ты жульничаешь!");
                Console.WriteLine("2. Видимо так и есть! Вот это мне повезло с тобой!");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Я не думаю, что клеветать на меня - лучшая идея сейчас! Мы еще не так хорошо знакомы.");
                    Console.WriteLine("");
                    Console.WriteLine("< нажми любую клавишу >");
                    Console.ReadLine();
                    Console.WriteLine("О нет, ты посмотри на это!");
                }
                else if (a == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Ох, спасибо! Похоже ты обладаешь даром проницательности!");
                    Console.WriteLine("");
                    Console.WriteLine("< нажми любую клавишу >");
                    Console.ReadLine();
                    Console.WriteLine("О нет, ты посмотри на это!");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Я тебя не понимаю. Ну видимо ничего важного ты не сказал.");
                    Console.WriteLine("");
                    Console.WriteLine("< нажми любую клавишу >");
                    Console.ReadLine();
                    Console.WriteLine("О нет, ты посмотри на это!");
                }

            Console.WriteLine("");
            Console.WriteLine("- Перед тобой возникает неизвестный объект! Хочешь ли ты его исследовать?");
            do
            {
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                Console.WriteLine("3. Не могу решить");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    character.check_object();
                }
                else if (a == 2)
                {
                    Console.WriteLine("- Возможно, твоя осторожность спасла тебя от проблем... или лишила тебя возможности найти что-то ценное...");
                }
                else if (a == 3)
                {
                    Console.WriteLine("- Ты отдал свою судьбу в волю случая!");
                    character.check_object();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Что ты говоришь? Ты хочешь узнать, что это такое?");
                }
            } while (a != 1 ^ a != 2 ^ a != 3);
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("- Кто бы мог подумать, что все так выйдет...");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();

            Console.WriteLine("- Ой, опять что-то непонятное лежит недалеко от нашего пути. Пойдем посморим, что там такое?");
            do
            {
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                Console.WriteLine("3. Не могу решить");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    character.check_object();
                }
                else if (a == 2)
                {
                    Console.WriteLine("- Возможно, твоя осторожность спасла тебя от проблем... или лишила тебя возможности найти что-то ценное...");
                }
                else if (a == 3)
                {
                    Console.WriteLine("- Ты отдал свою судьбу в волю случая!");
                    character.check_object();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Что ты говоришь? Ты хочешь узнать, что это такое?");
                }
            } while (a != 1 ^ a != 2 ^ a != 3);
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("- Вот это поворот...");
            Console.WriteLine("");
            Console.ReadLine();

            Console.WriteLine("- Перед тобой возникает монстр! Что ты хочешь предпринять?");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("1. Сразиться с помощью оружия");
                Console.WriteLine("2. Сразиться с помощью навыка");
                Console.WriteLine("3. Сбежать");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 3)
                {
                    character.run_away();
                }
                else if (a == 2)
                {
                    character.fight();
                }
                else if (a == 1)
                {
                    character.fight_weapon();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("- Прости, не расслышал. Что ты сказал?");
                }
            } while (a != 1 ^ a != 2 ^ a != 3);
            Console.WriteLine("");
            Console.WriteLine("- Я думаю, на сегодня приключений достаточно. Я так устал...");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("- Спокойной ночи...");
            Console.WriteLine("");
            Console.WriteLine("< нажми любую клавишу >");
            Console.ReadLine();
            Console.WriteLine("*конец вступительной части*");
            Console.ReadLine();
        }
    }
}
