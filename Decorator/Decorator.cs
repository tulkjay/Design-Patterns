using System;
using Decorator.Setup;

namespace Decorator
{
    public abstract class Decorator : Character
    {
        protected Character Character;

        public override void ShowBreakdown()
        {
            Character?.ShowBreakdown();
        }
    }
}