using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TeOhangaChaseV2 {
    public partial class MainForm : Form {

        private static Stopwatch mWatch = new Stopwatch();
        private static int mMsLeft;

        DataClass mySource = new DataClass();
        CashBuilderForm cashBuilderForm;



        WMPLib.WindowsMediaPlayer countDownMusic;
        WMPLib.WindowsMediaPlayer stopTheChase;
        WMPLib.WindowsMediaPlayer finalChaseChaserWins;
        WMPLib.WindowsMediaPlayer finalChasePlayerWins;
        WMPLib.WindowsMediaPlayer finalChaseChaserCorrect;
        WMPLib.WindowsMediaPlayer finalChasePlayerCorrect;
        WMPLib.WindowsMediaPlayer playerCorrect;
        WMPLib.WindowsMediaPlayer cashBuilderMusic;

        public MainForm() {
            cashBuilderForm = new CashBuilderForm();
            InitializeComponent();
            soundIntialization();
        }


        // --------------------------- Start of Cash Builder Code ---------------------------
        private void launchCashBuilder_Click(object sender, EventArgs e) {
            Thread thread = new Thread(RunCashBuilderForm);
            thread.Start();
        }

        public void RunCashBuilderForm() {
            CashBuilderForm cashBuilderForm = new CashBuilderForm();
            cashBuilderForm.ShowDialog();

        }

        private void mainTimer_Tick(object sender, EventArgs e) {
            
            mMsLeft -= (int)mWatch.ElapsedMilliseconds;
            mWatch.Restart();
            

            int minutes = mMsLeft / 60000;
            int seconds = (mMsLeft - (minutes * 60000)) / 1000;
            string timeLeftString = string.Format("{0}:{1:00}", minutes, seconds);

            testLabel.Text = timeLeftString;

            cashBuilderForm.SetTestLabel(timeLeftString);
           
        }

        private void startTimerCB_Click(object sender, EventArgs e) {
            mMsLeft = 60000;
            mainTimer.Interval = 500;

           
            mainTimer.Start();
            mWatch.Start();
            countDownMusic.controls.play();

        }

        // Resets game incase of accidental press of start
        private void resetGameCB_Click(object sender, EventArgs e) {
            mainTimer.Stop();
            mWatch.Stop();
            countDownMusic.controls.stop();
        }

        // --------------------------- END of Cash Builder Code ---------------------------

        public void soundIntialization() {
            countDownMusic = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\MinCountdown.mp3" };
            stopTheChase = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\StopTheClock.mp3" };
            finalChaseChaserWins = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\FinalChaseChaserWins.mp3" };
            finalChasePlayerWins = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\FinalChasePlayerWins.mp3" };
            finalChaseChaserCorrect = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\FinalChaseChaserCorrect.mp3" };
            finalChasePlayerCorrect = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\FinalChasePlayerCorrect.mp3" };
            playerCorrect = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\PlayerCorrect.mp3" };
            cashBuilderMusic = new WMPLib.WindowsMediaPlayer { URL = "GameSounds\\CashBuilderMusic.mp3" };

            countDownMusic.controls.stop();
            stopTheChase.controls.stop();
            finalChaseChaserWins.controls.stop();
            finalChasePlayerWins.controls.stop();
            finalChaseChaserCorrect.controls.stop();
            finalChasePlayerCorrect.controls.stop();
            playerCorrect.controls.stop();
            cashBuilderMusic.controls.stop();

        }


    }
}
