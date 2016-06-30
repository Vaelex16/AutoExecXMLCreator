using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoExecXMLCreator
{
    class Storage
    {
        // Store the characters and the overall list of commands
        public List<string> characters = new List<string>();
        public List<Command> commands = new List<Command>();

        //  Bools to determine where the command can be received form
        public bool party = false;
        public bool tell = false;
        public bool ls = false;
        public bool ls2 = false;

        public struct Command
        {
            public string command;
            public string chatValue;
            public AbilityType type;
            public bool self;

            public Command (string _command, string _charValue, AbilityType _type, bool _self)
            {
                command = _command;
                chatValue = _charValue;
                type = _type;
                self = _self;
            }
        }

        public enum AbilityType
        {
            MagicAttack,
            Buff,
            JobAbility,
            WeaponSkill
        }
    }
}
