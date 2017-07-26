using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Arena
    {
        Monster monster = new Monster();
        Swordsman swordsman = new Swordsman();
        Archer archer = new Archer();

        public void Fight(int i)
        {
            if(i == 1)
            {
                Console.WriteLine("\nYour character is : ");
                Console.WriteLine("Swordsman");

                int round = 1;

                while(swordsman.health > 0 && monster.Health > 0)
                {
                    Console.WriteLine("\n======CURRENT STATUS=====");
                    Console.WriteLine("---------Swordsman---------");
                    Console.WriteLine("HP   : {0}", swordsman.health);
                    Console.WriteLine("Mana : {0}", swordsman.mana);
                    Console.WriteLine("----------Monster----------");
                    Console.WriteLine("HP   : {0}", monster.Health);
                    Console.WriteLine("Mana : {0}", monster.Mana);
                    Console.WriteLine("\n BATTLE START : ROUND {0}", round);
                    Console.WriteLine("\n Swordsman Turn.");
                    Console.WriteLine("1.Attack");
                    Console.WriteLine("2.CrossSword");
                    Console.WriteLine("3.Heal");
                    Console.WriteLine("4.Charged Mana");
                    Console.WriteLine("Choose : ");

                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.WriteLine("Swordsman : Attack ");
                        swordsman.Attack(monster);
                    }
                    if (choose == 2)
                    {
                        Console.WriteLine("Swordsman : CrossSword ");
                        swordsman.CrossSword(monster);
                    }
                    if (choose == 3)
                    {
                        Console.WriteLine("Swordsman : Heal");
                        swordsman.Heal();
                    }
                    if (choose == 4)
                    {
                        Console.WriteLine("Mana charged success.");
                        swordsman.ChargedMana();
                    }

                    Console.WriteLine("\n Monster Turn.");
                    monster.Attack(swordsman);
                    Console.WriteLine("Monster Attack");
                    round++;
                }
                if (swordsman.health <= 0 && monster.Health > 0)
                {
                    Console.WriteLine("You Lose..:'(");
                    Console.ReadKey();
                }
                else if (swordsman.health > 0 && monster.Health <= 0)
                {
                    Console.WriteLine("You Win");
                    Console.ReadKey();
                }
                else if (swordsman.health <= 0 && monster.Health <= 0)
                {
                    Console.WriteLine("Draw");
                    Console.ReadKey();
                }

                round++;
            }
            else
            {
                Console.WriteLine("\nYour character is : ");
                Console.WriteLine("Archer.");
                int round = 1;

                while (archer.health > 0 && monster.Health > 0)
                {
                    Console.WriteLine("\n======CURRENT STATUS=====");
                    Console.WriteLine("-----------Archer----------");
                    Console.WriteLine("HP   : {0}", archer.health);
                    Console.WriteLine("Mana : {0}", archer.mana);
                    Console.WriteLine("----------Monster----------");
                    Console.WriteLine("HP   : {0}", monster.Health);
                    Console.WriteLine("Mana : {0}", monster.Mana);
                    Console.WriteLine("\n BATTLE START : ROUND {0}", round);
                    Console.WriteLine("\n Archer Turn.");
                    Console.WriteLine("1.Attack");
                    Console.WriteLine("2.Attack Range");
                    Console.WriteLine("3.Heal");
                    Console.WriteLine("4.Charged Mana");
                    Console.WriteLine("Choose : ");

                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.WriteLine("Archer : Attack ");
                        archer.Attack(monster);
                    }
                    if (choose == 2)
                    {
                        Console.WriteLine("Archer : Attack Range ");
                        archer.AttackRange(monster);
                    }
                    if (choose == 3)
                    {
                        Console.WriteLine("Archer : Heal");
                        archer.Heal();
                    }
                    if (choose == 4)
                    {
                        Console.WriteLine("Mana charged success");
                        archer.ChargedMana();
                    }
                    Console.WriteLine("\n Monster Turn.");
                    monster.Attack(archer);
                    Console.WriteLine("Monster Attack");
                    round++;
                }
                if (archer.health <= 0 && monster.Health > 0)
                {
                    Console.WriteLine("You Lose..:'(");
                    Console.ReadKey();
                }
                else if (archer.health > 0 && monster.Health <= 0)
                {
                    Console.WriteLine("You Win");
                    Console.ReadKey();
                }
                else if (archer.health <= 0 && monster.Health <= 0)
                {
                    Console.WriteLine("Draw");
                    Console.ReadKey();
                }

                round++;
            }
        }
    }
}
