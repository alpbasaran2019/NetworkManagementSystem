using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.MyComponent
{
    public sealed class MyBool
    {
        private Boolean l_booleanValue;
        public MyBool()
        { l_booleanValue = false; }
        public bool Value
        {
            get { return l_booleanValue; }
            set
            {
                l_booleanValue = value;
                if (ValueChanged != null)
                    ValueChanged(value);
            }
        }
        public event ValueChangedEventHandler ValueChanged;
    }
   public delegate void ValueChangedEventHandler(bool value);
}

