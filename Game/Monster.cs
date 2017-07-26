using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Monster
    {
        private int _hp;
        private int _mp;

        Random random = new Random();

        public int Health
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int Mana
        {
            get { return _mp; }
            set { _mp = value; }
        }

        public Monster()
        {
            _hp = 740;
            _mp = 140;
        }

        public void Attack(Novice enemy)
        {
            _mp = _mp - 10;
            enemy.health = enemy.health - 35;
            int attack = random.Next(_mp, enemy.health);
        }
    }
}
