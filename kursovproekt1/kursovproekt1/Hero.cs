using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kursovproekt1
{
    public class Hero
    {
        private double attackCoef = 15;

        private double defenceCoef = 20;

        public Hero(string name, Fraction fraction)
        {
            this.Name = name;
            this.Fraction = fraction;
            this.Level = 0;
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            this.ItemSet = new List<Item>();
        }

        public string Name { get; private set; }

        public Fraction Fraction { get; set; }

        public int Level { get; private set; }

        public double Health { get; private set; }

        public double Stamina { get; private set; }

        public double Mana { get; private set; }

        public List<Item> ItemSet { get; }

        public int LevelUp()
        {
            this.Level++;
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            return this.Level;
        }
        public double GetAttack()
        {
            double getAttack = this.ItemSet.Sum(i => i.Attack);
            getAttack += this.Level * this.attackCoef;
            return getAttack;
        }
        public double GetDefence()
        {
            double getDefence = this.ItemSet.Sum(i => i.Defence);
            getDefence += this.Level * this.defenceCoef;
            return getDefence;
        }
    }
}
