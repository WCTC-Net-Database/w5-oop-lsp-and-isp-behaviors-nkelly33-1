using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Archer : IEntity, IShootable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Shoot(target);
        }

        public void Move()
        {
            Console.WriteLine("he move");
        }

        public void Shoot(IEntity target)
        {
            Console.WriteLine($"he shoot {target.Name}");
        }
    }
}