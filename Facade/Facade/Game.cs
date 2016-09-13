using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void GameStateChangedEventHandler(object sender, EventArgs e);
    public class Game
    {
        public enum GameState { off, on }
        public event GameStateChangedEventHandler GameStateChanged;

        private GameState _GameState;

        public GameState m_GameState
        {
            get
            {
                return _GameState;
            }
            set
            {
                _GameState = value;
                if (GameStateChanged != null)
                    GameStateChanged(this, new EventArgs());
            }
        }
    }
}
