using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Kalcium
{
    public static class Event
    {
        public static void Raise(this EventHandler me, object sender)
        {
            if (me != null)
                me(sender, EventArgs.Empty);
        }

        public static void Raise(this Action me)
        {
            if (me != null)
                me();
        }

        public static void Raise<T>(this Action<T> me, T argument)
        {
            if (me != null)
                me(argument);
        }

        public static void Raise(this PropertyChangedEventHandler me, string property, object sender)
        {
            if (me != null)
                me(sender, new PropertyChangedEventArgs(property));
        }
    }
}
