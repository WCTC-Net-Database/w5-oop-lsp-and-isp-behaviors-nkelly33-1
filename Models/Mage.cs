using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Mage : IEntity, ICastable
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("mage move");
        }

        public void CastSpell(string spellName, IEntity target)
        {
            Console.WriteLine($"he {spellName} {target.Name}");
        }

        public void Attack(IEntity target)
        {
            CastSpell("spell", target);
        }
    }
}
