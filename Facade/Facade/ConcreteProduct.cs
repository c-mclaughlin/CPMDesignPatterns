using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ConcreteProduct : Product
    {
        public Product product;

        public ConcreteProduct()
        {

        }

        public ConcreteProduct(TV.TVPowerState PowerState, TV.TVInputState InputState, SurroundSound.SoundState SoundState, DVD.DVDState DVDState, Game.GameState GameState)
        {
            product = new Product(PowerState, InputState, SoundState, DVDState, GameState);
            product.Visible = true;
        }

    }
}
