using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_Ivanov
{
    public abstract class Time
    {
        public abstract string PrintTime();
    }

    public sealed class TimeEU : Time
    {
        protected CultureInfo time = new CultureInfo("es-ES", false);
        public override string PrintTime()
        {
            return DateTime.Now.ToString(time);
        }
    }
    public sealed class TimeUS : Time
    {
        protected CultureInfo time = new CultureInfo("en-US", false);
        public override string PrintTime()
        {
            return DateTime.Now.ToString(time);
        }
    }
    public abstract class Decorator : Time
    {
        private Time time;
        public Decorator(Time time)
        {
            this.time = time;  
        }
        public override string PrintTime()
        {
            return time.PrintTime();
        }
    }
    public sealed class InsertTextEU : Decorator
    {
        public InsertTextEU(TimeEU time) : base(time) { }
        public override string PrintTime()
        {
            StringBuilder text = new StringBuilder(base.PrintTime());
            text.Insert(17, " <- right now! ");
            return text.ToString();
        }
    }
    public sealed class InsertTextUS : Decorator
    {
        public InsertTextUS(TimeUS time) : base(time) { }
        public override string PrintTime()
        {
            StringBuilder text = new StringBuilder(base.PrintTime());
            text.Insert(20, " <- right now! ");
            return text.ToString();
        }
    }
}
