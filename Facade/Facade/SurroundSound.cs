using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void SurroundSoundStateChangedEventHandler(object sender, EventArgs e);

    public class SurroundSound
    {
        public enum SoundState {off, low, medium, loud}
        public event SurroundSoundStateChangedEventHandler SurroundSoundStateChanged;

        private SoundState _SSState;

        public SoundState m_SSState
        {
            get
            {
                return _SSState;
            }
            set
            {
                _SSState = value;
                if (SurroundSoundStateChanged != null)
                    SurroundSoundStateChanged(this, new EventArgs());
            }
        }
      /*  public bool Start()
        {
            m_SSState = SoundState.low;
            return true;
        }
        public bool Stop()
        {
            m_SSState = SoundState.off;
            return true;
        }
        public bool Cable()
        {
            m_SSState = SoundState.low;
            return true;
        }
        public bool DVD()
        {
            m_SSState = SoundState.medium;
            return true;
        }
        public bool Game()
        {
            m_SSState = SoundState.loud;
            return true;
        }
        */


    }
}
