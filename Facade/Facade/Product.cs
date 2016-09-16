using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class Product : Form
    {
        public Product()
        {

        }

        public Product(TV.TVPowerState PowerState, TV.TVInputState InputState, SurroundSound.SoundState SoundState, DVD.DVDState DVDState, Game.GameState GameState)
        {
            InitializeComponent();
            pwrState.Text = PowerState.ToString();
            inpState.Text = InputState.ToString();
            sndState.Text = SoundState.ToString();
            dvdState.Text = DVDState.ToString();
            gameState.Text = GameState.ToString();
        }
    }
}
