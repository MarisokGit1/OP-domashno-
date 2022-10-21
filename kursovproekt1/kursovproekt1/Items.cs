using System;
using System.Collections.Generic;
using System.Text;

namespace kursovproekt1
{
    public class Item
    {
        public Item(string name, double atk, double def)
        {
            if (atk > 10 || atk < 0)
                throw new Exception("Invalid Attack");
            else if (def > 10 || def < 0)
                throw new Exception("Invalid Defence");
            else
            {
                Name = name;
                Attack = atk;
                Defence = def;
            }
        }

        public string Name { get; private set; }

        public double Attack { get; private set; }

        public double Defence { get; private set; }

        public void UpgradeAttack(double atk)
        {
            if (atk < 0 || atk > 50)
                throw new Exception("Invalid Attack improvement value");
            else
                this.Attack += atk;
        }
        public void UpgradeDefence(double def)
        {
            if (def < 0 || def > 50)
                throw new Exception("Invalid Defence improvement value");
            else
                this.Defence += def;
        }
    }
}