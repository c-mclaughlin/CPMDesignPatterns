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
    public partial class Remote : Form
    {
        TV tv;
        SurroundSound ss;
        DVD dvd;
        Game gs;

        public Remote()
        {
            InitializeComponent();
            tv = new TV();
            ss = new SurroundSound();
            dvd = new DVD();
            gs = new Game();
            tv.TVStateChanged += new TVStateChangedEventHandler(tv_TVStateChanged);
            ss.SurroundSoundStateChanged += new SurroundSoundStateChangedEventHandler(ss_SurroundSoundStateChanged);
            dvd.DVDStateChanged += new DVDStateChangedEventHandler(dvd_DVDStateChanged);
            gs.GameStateChanged += new GameStateChangedEventHandler(gs_GameStateChanged);
            UpdateControls();

        }

        void tv_TVStateChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        void ss_SurroundSoundStateChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        void dvd_DVDStateChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        void gs_GameStateChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        public void UpdateControls()
        {
            TVPowerState.Text = tv.m_State.ToString();
            TVInputState.Text = tv.m_InputState.ToString();
            SoundState.Text = ss.m_SSState.ToString();
            DVDPowerState.Text = dvd.m_DVDState.ToString();
            GamePowerState.Text = gs.m_GameState.ToString();

        }



        private void PowerBtn_Click(object sender, EventArgs e)
        {
            tv.m_State = TV.TVPowerState.on;
            //tv.Start();
            ss.m_SSState = SurroundSound.SoundState.low;
        }


        private void PowerBtn2_Click(object sender, EventArgs e)
        {
            tv.m_State = TV.TVPowerState.off;
            //tv.Stop();
            ss.m_SSState = SurroundSound.SoundState.off;
            dvd.m_DVDState = DVD.DVDState.off;
            gs.m_GameState = Game.GameState.off;
        }

        private void CableBtn_Click(object sender, EventArgs e)
        {
            tv.m_InputState = TV.TVInputState.cable;
            ss.m_SSState = SurroundSound.SoundState.low;
            dvd.m_DVDState = DVD.DVDState.off;
            gs.m_GameState = Game.GameState.off;
        }


        private void DVDBtn_Click(object sender, EventArgs e)
        {
            tv.m_InputState = TV.TVInputState.DVD;
            dvd.m_DVDState = DVD.DVDState.on;
            gs.m_GameState = Game.GameState.off;
            ss.m_SSState = SurroundSound.SoundState.medium;
        }

        private void GameBtn_Click(object sender, EventArgs e)
        {
            tv.m_InputState = TV.TVInputState.game;
            gs.m_GameState = Game.GameState.on;
            dvd.m_DVDState = DVD.DVDState.off;
            ss.m_SSState = SurroundSound.SoundState.loud;
        }
    }
}
