using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature_Manager
{
    public class AnimatedObject : Creature
    {

        public AnimatedObject(string size) {

            _con = 0;
            _int = -4;
            _wis = -4;
            _cha = -5;

            switch (size) {

                case "tiny":

                    _hp = 20;
                    //AC 18
                    _addToAttack = 8;
                    _addToDamage = 4;
                    _diceAmount = 1;
                    _diceSize = 4;

                    _str = -3;
                    _dex = 4;
                    break;
                case "small":

                    _hp = 25;
                    //AC 16
                    _addToAttack = 6;
                    _addToDamage = 2;
                    _diceAmount = 1;
                    _diceSize = 8;

                    _str = -2;
                    _dex = 2;
                    break;
                case "medium":

                    _hp = 40;
                    //AC 13
                    _addToAttack = 5;
                    _addToDamage = 1;
                    _diceAmount = 2;
                    _diceSize = 6;

                    _str = 0;
                    _dex = 1;
                    break;
                case "large":

                    _hp = 50;
                    //AC 10
                    _addToAttack = 6;
                    _addToDamage = 2;
                    _diceAmount = 2;
                    _diceSize = 10;

                    _str = 2;
                    _dex = 0;
                    break;
                case "huge":

                    _hp = 80;
                    //AC 10
                    _addToAttack = 8;
                    _addToDamage = 4;
                    _diceAmount = 2;
                    _diceSize = 12;

                    _str = 4;
                    _dex = -2;
                    break;
            }

        }

    }
}
