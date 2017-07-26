using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Swordsman : Novice
    {
        public Swordsman()
        {
            health = 660;
            mana = 140;
        }

        public override void Attack(Monster enemy)
        {
            mana = mana - 10;
            enemy.Health = enemy.Health - 45;
        }
        public void CrossSword(Monster enemy)
        {
            mana = mana - 15;
            enemy.Health = enemy.Health - 75;
        }
        public void Heal()
        {
            health = health + 15;
            mana = mana - 10;
        }
        public void ChargedMana()
        {
            mana = mana + 15;
        }
    }
}
