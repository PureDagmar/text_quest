using System;
using System.Collections.Generic;
using System.Text;

namespace tekstquestconsol
{
    abstract class Character
    {
        //Скрытые поля класса
        public string name;        //поле для определения имени персонажа в игре
        public string weapon;      //поле для определения оружия персонажа в игре
        public int lives;          //поле для определения количества жизней персонажа в игре
        //Конструктор класса
        public Character()
        {
            this.name = name;
            this.weapon = weapon;
            this.lives = lives;

        }

        //Абстрактный метод, который решает, что обнаружит персонаж
        public abstract void check_object();

        //Абстрактный метод, который решает успешный или не совсем успешный будет побег
        public abstract void run_away();

        //Абстрактный метод, который решает как пройдет сражение с применением спец навыка
        public abstract void fight();

        //Абстрактный метод, который решает как пройдет сражение c применением оружия
        public abstract void fight_weapon();

        //Абстрактный метод, который возвращает способность
        public abstract string get_power();

        //Абстрактный метод, который возвращает количество жизней
        public abstract string get_lives();
    }
}
