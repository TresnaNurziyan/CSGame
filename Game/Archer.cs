using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Archer : Novice
    {
        public Archer()
        {
            health = 400;
            mana = 270;
        }

        public override void Attack(Monster enemy)
        {
            mana = mana - 10;
            enemy.Health = enemy.Health - 20;
        }
        public void AttackRange(Monster enemy)
        {
            mana = mana - 15;
            enemy.Health = enemy.Health - 65;
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
