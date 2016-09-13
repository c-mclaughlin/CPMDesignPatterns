using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void TVStateChangedEventHandler(object sender, EventArgs e);
    public class TV
    {
       public enum TVPowerState {off, on}
       public enum TVInputState {cable, DVD, game}
       public event TVStateChangedEventHandler TVStateChanged;
       private TVPowerState _PowerState;
        private TVInputState _InputState;

       public TVPowerState m_State
       {
            get
            {
                return _PowerState;
            }

            set
            {
                _PowerState = value;
                if (TVStateChanged != null)
                    TVStateChanged(this, new EventArgs());
            }
       }
        public TVInputState m_InputState
        {
            get
            {
                return _InputState;
            }
            set
            {
                _InputState = value;
                if (TVStateChanged != null)
                    TVStateChanged(this, new EventArgs());
            }
        }
        public bool Start()
        {
            m_State = TVPowerState.on;
            return true;
        }
        public bool Stop()
        {
            m_State = TVPowerState.off;
            return true;
        }
    }
}
