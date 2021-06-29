using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_and_polymorphism
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }

    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    class SpecialInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a special character input in a numeric only field. This fired an error!";
        }
    }

    class Special2InputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a special character input in a numeric only field. This fired an error!";
        }
    }
}
