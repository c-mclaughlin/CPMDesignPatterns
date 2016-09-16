using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
   public abstract class Factory
    {
        public void MakeSettings(TV.TVPowerState PowerState, TV.TVInputState InputState, SurroundSound.SoundState SoundState, DVD.DVDState DVDState, Game.GameState GameState)
        {
          Product product = factoryMethod(PowerState, InputState, SoundState, DVDState, GameState);
        }

        internal abstract Product factoryMethod(TV.TVPowerState PowerState, TV.TVInputState InputState, SurroundSound.SoundState SoundState, DVD.DVDState DVDState, Game.GameState GameState);
    }
}
