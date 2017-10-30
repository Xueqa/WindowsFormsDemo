using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDemo
{
    class Character
    {
        // 尝试使用 properties
        // 参考SC_model，里面有serialize序列化
        private string name;
        private int age;
        private int  gender;
        private int health;
        private int damage;
        private int defend;
        public string Getname(string name)
        {
            this.name = name;
            return name;
        }
        public void Getage(int age)
        {
            this.age = age;
        }
        public int Gethealth(int health)
        {
            this.health = health ;
            return health;
        }
        public int Getdamage(int damage)
        {
            this.damage  = damage ;
            return damage;
        }
        public int Getdefend(int defend)
        {
            this.defend  = defend ;
            return defend;
        }
        public void Getgender(int gender)
        {
            this.gender  = gender;
        }
    }
}

