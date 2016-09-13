using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public delegate void DVDStateChangedEventHandler(object sender, EventArgs e);

    public class DVD
    {
        public event DVDStateChangedEventHandler DVDStateChanged;
        public enum DVDState {off, on }
        private DVDState _DVDState;
        public DVDState m_DVDState
        {
            get
            {
                return _DVDState;
            }
            set
            {
                _DVDState = value;
                if (DVDStateChanged != null)
                    DVDStateChanged(this, new EventArgs());
            }
        }
    }
}
