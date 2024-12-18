using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;

namespace Creature_Manager
{
    public abstract class Creature
    {

        //I WILL FIX THIS WHEN IT BECOMES RELEVANT AGAIN
        //public int _wizLevel = int.Parse(ConfigurationManager.AppSettings["wizLevel"]!);
        //public int _wizProficiency = int.Parse(ConfigurationManager.AppSettings["wizProficiency"]!);

        public int _wizLevel = 10;
        public int _wizProficiency = 4;

        public int _hp = 0;
        public int _diceAmount = 0;
        public int _diceSize = 0;
        public int _addToAttack = 0;
        public int _addToDamage = 0;

        public int _str = 0;
        public int _dex = 0;
        public int _con = 0;
        public int _int = 0;
        public int _wis = 0;
        public int _cha = 0;

        public Creature() {

        }

        public virtual int SavingThrow(string type)
        {

            switch (type)
            {
                case "str":
                    return DiceRoller.RollDice(1, 20) + _str;
                case "dex":
                    return DiceRoller.RollDice(1, 20) + _dex;
                case "con":
                    return DiceRoller.RollDice(1, 20) + _con;
                case "int":
                    return DiceRoller.RollDice(1, 20) + _int;
                case "wis":
                    return DiceRoller.RollDice(1, 20) + _wis;
                case "cha":
                    return DiceRoller.RollDice(1, 20) + _cha;
                default:
                    return 0;
            }

        }

        public virtual bool takeDamage(int damage, bool isLethal) {

            if (isLethal)
            {
                _hp -= (damage * 2);
            }
            else
            {
                _hp -= damage;
            }

            if (_hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string rollAttack(string name) {

            int attackRoll = DiceRoller.RollDice(1, 20);

            if (attackRoll == 20)
            {
                return $"The {this.GetType().Name}({name}) has rolled a {attackRoll + _addToAttack} for a CRITICAL hit: {DiceRoller.RollDice(_diceAmount * 2, _diceSize) + _addToDamage} damage.";
            }
            else {
                return $"The {this.GetType().Name}({name}) has rolled a {attackRoll + _addToAttack} to hit for {DiceRoller.RollDice(_diceAmount, _diceSize) + _addToDamage} damage.";
            }
        }

        public override string ToString() {

            return $"Creature: {this.GetType().Name}\nHP: {_hp}\nAttack Bonus: {_addToAttack}\nDamage Bonus: {_addToDamage}\n";

        }

    }
}
