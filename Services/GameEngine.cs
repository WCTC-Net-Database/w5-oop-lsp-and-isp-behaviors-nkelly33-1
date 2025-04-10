using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _mage;
        private readonly IEntity _archer;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mage , IEntity archer)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mage = mage;
            _archer = archer;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _mage.Name = "Mage";
            _archer.Name = "Archer";


            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost) _ghost).Fly();

            _mage.Move();
            _mage.Attack(_goblin);

            _archer.Move();
            _archer.Attack(_goblin);

        }
    }
}
