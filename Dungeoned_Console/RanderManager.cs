using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoned_Console
{
    public enum RanderLayer
    {
        None = 0,
        Scene,
        UI,
    }

    public class RanderEntityBase
    {
        //public virtual 
    }

    public class RanderManager
    {
    }

    public abstract class RanderBase
    {

        public abstract RanderLayer CurLayer { get; }


    }
}
