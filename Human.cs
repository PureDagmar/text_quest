using System;
using System.Collections.Generic;
using System.Text;

namespace tekstquestconsol
{
    class Human : Character
    {
        //Внутреннее поле класса
        public string skill;       //поле для определения навыка персонажа в игре

        //Конструктор класса
        public Human(string name, string weapon) : base()
        {
            this.name = name;
            this.weapon = weapon;
            this.lives = 5;
            this.skill = "хитрость";
        }

        public override string get_power()
        {
            return this.skill;
        }

        public override string get_lives()
        {
            return Convert.ToString(lives);
        }
        public override void check_object()
        {
            Console.WriteLine("Ты подходишь ближе...Присматриваешься, принюхиваешься...");
            Console.WriteLine("Да это же....");
            Random rnd = new Random();
            int result = rnd.Next(1, 5);
            if (result == 1)
            {
                Console.WriteLine("...большая глыба из камня. Ты не нашел ничего инетерсного, продолжай свой путь");
            }
            else if (result == 2)
            {
                Console.WriteLine("... зуб дракона. Ты не заметил, как оказался прямо в его пасти! Ты теряешь жизнь, как только его челюсти смыкаются над твоей человеческой головой!");
                this.lives -= 1;
                string lives = this.lives.ToString();
                Console.WriteLine($"У тебя осталось {lives} жизней ");
            }
            else if (result == 3)
            {
                Console.WriteLine("... целительный обелиск! Ты подходишь к нему и количество твоих жизней увеличивается на 1 единицу.");
                this.lives += 1;
                string lives = this.lives.ToString();
                Console.WriteLine($"У тебя стало {lives} жизней ");
            }
            else if (result == 4)
            {
                Console.WriteLine("...остатки после привала других путников. Ничего кроме золы и рыбьих костей. Идем дальше.");
            }
            else
            {
                Console.WriteLine("...кустарник брусники. Ты съедаешь пару кислых ягод и возвращаешься на тропу.");
            }
        }
        public override void run_away()
        {
            Console.WriteLine($"Ты пытаешься сбежать!");
            Console.WriteLine($"...");
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                Console.WriteLine($"Человек, тебе удается остаться незамеченным и замести свои следы");
            }
            else
            {
                Console.WriteLine($"Ты в ужасе пытаешься сбежать от врага! Тебе это удается, но он успел тебя ранить! Ты теряешь жизнь!");
                this.lives -= 1;
                string lives = this.lives.ToString();
                Console.WriteLine($"У тебя осталось {lives} жизней ");
            }
        }

        public override void fight()
        {
            Console.WriteLine($"Сражение началось!");
            Console.WriteLine($"...");
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                Console.WriteLine($"Тебе удалось победить врага с помощью твоей {this.skill}! Можешь двигаться дальше!");
            }
            else
            {
                Console.WriteLine($"Твоя {this.skill} была рассекречена! Ты потерял жизнь!");
                this.lives -= 1;
                string lives = this.lives.ToString();
                Console.WriteLine($"У тебя осталось {lives} жизней ");
            }
        }

        public override void fight_weapon()
        {
            Console.WriteLine($"Сражение началось!");
            Console.WriteLine($"...");
            Random rnd = new Random();
            int result = rnd.Next(1, 3);
            if (result % 2 == 1)
            {
                Console.WriteLine($"Тебе удалось победить врага! Ты умело использовал свой {this.weapon}! Можем двигаться дальше!");
            }
            else
            {
                Console.WriteLine($"Твой {this.weapon} был повержен! Ты потерял жизнь!");
                this.lives -= 1;
                string lives = this.lives.ToString();
                Console.WriteLine($"У тебя осталось {lives} жизней ");
            }
        }
    }
}
