using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ConcreteFactory : Factory
    {
        internal override Product factoryMethod(TV.TVPowerState PowerState, TV.TVInputState InputState, SurroundSound.SoundState SoundState, DVD.DVDState DVDState, Game.GameState GameState)
        {
            return new ConcreteProduct(PowerState, InputState, SoundState, DVDState, GameState);
        }
    }
}
