using System;

namespace kursovproekt1
{
    class main
    {
        static void Main(string[] args)
        {
            Hero HuTao = new Hero("Hu Tao", Fraction.Rogue);
            Item StaffOfHoma = new Item("StaffOfHoma", 9, 4);
            HuTao.LevelUp();
            Item CWOF = new Item("Crimson Witch of Flame", 7, 6);
            HuTao.ItemSet.Add(CWOF);
            HuTao.ItemSet.Add(StaffOfHoma);
            HuTao.LevelUp();
            CWOF.UpgradeAttack(40);
            StaffOfHoma.UpgradeAttack(30);
            HuTao.LevelUp();

            Hero Zhongli = new Hero("Zhongli", Fraction.Rogue);
            Item VortexVanquisher = new Item("Vortex Vanquisher", 5, 3);
            Zhongli.LevelUp();
            Item TOTM  = new Item("Tenacity of the Millelith", 8, 9);
            Zhongli.ItemSet.Add(VortexVanquisher);
            Zhongli.ItemSet.Add(TOTM);
            Zhongli.LevelUp();
            VortexVanquisher.UpgradeAttack(21);
            TOTM.UpgradeAttack(48);
            Zhongli.LevelUp();
          

            Console.WriteLine("-----------------Statistics-----------------");
            Console.WriteLine(HuTao.Name + " have " + HuTao.GetAttack() + " Attack and " + HuTao.GetDefence() + " Defence");
            Console.WriteLine(Zhongli.Name + " have " + Zhongli.GetAttack() + " Attack and " + Zhongli.GetDefence() + " Defence");
        }
    }
}