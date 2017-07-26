using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface ISwordsmanAttack
    {
        void CrossSword(Monster enemy);
        void Heal();    
    }
}
