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

        CashBuilderForm cashBuilderForm;

        // Perhaps create a class to hold all the questions for chaser vs player

        private static Stopwatch mWatch = new Stopwatch();
        private static int mMsLeft;

        // Cashbuilder, Chaser vs player, final chase
        private bool playingCB = false;
        private bool playingCVP = false;
        private bool playingFC = false;

        DataClass mySource = new DataClass();
        

        WindowsMediaPlayer countDownMusic;
        WindowsMediaPlayer stopTheChase;
        WindowsMediaPlayer finalChaseChaserWins;
        WindowsMediaPlayer finalChasePlayerWins;
        WindowsMediaPlayer finalChaseChaserCorrect;
        WindowsMediaPlayer finalChasePlayerCorrect;
        WindowsMediaPlayer playerCorrect;
        WindowsMediaPlayer cashBuilderMusic;

        public MainForm() {
            InitializeComponent();
            Console.WriteLine("Running on Thread" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            soundIntialization();
            
        }

        // Timer used to update timeLeft on mainform and cashbuilderform
        private void mainTimer_Tick(object sender, EventArgs e) {
            string timeLeftString;

            mMsLeft -= (int)mWatch.ElapsedMilliseconds;
            mWatch.Restart();

            // Formats time to be in minutes:seconds
            int minutes = mMsLeft / 60000;
            Console.WriteLine(minutes);
            if (minutes >= 0) {
                int seconds = (mMsLeft - (minutes * 60000)) / 1000;
                timeLeftString = string.Format("{0}:{1:00}", minutes, seconds);
            } else {

                timeLeftString = "0:00";
                mainTimer.Stop();
                mWatch.Stop();
            }

            mySource.TimeLeft = timeLeftString;
            timeLabelMain.Text = mySource.TimeLeft;

            if (playingCB) {
                cashBuilderForm.SetTimeLeftCB(mySource.TimeLeft);
                if (timeLeftString == "0:00") {
                    playingCB = false;
                }
            }

            if (playingCVP) {
                Console.WriteLine("Playing Chaser vs player");
            }

            if (playingFC) {
                Console.WriteLine("Playing Final Chase");
            }
        }

        // --------------------------- Start of Cash Builder Code ---------------------------
        private void launchCashBuilder_Click(object sender, EventArgs e) {
            Thread thread = new Thread(RunCashBuilderForm);
            thread.Start();
            
        }

        public void RunCashBuilderForm() {
            cashBuilderForm = new CashBuilderForm();
            cashBuilderForm.ShowDialog();


        }

        // Starts the cashBuilder game
        private void startTimerCB_Click(object sender, EventArgs e) {
            playingCB = true;
            mMsLeft = 60000;
            mainTimer.Interval = 100;
 
            mainTimer.Start();
            mWatch.Start();
            cashBuilderMusic.controls.play();

        }

        // Resets game and all values back to default
        private void resetGameCB_Click(object sender, EventArgs e) {
            mainTimer.Stop();
            mWatch.Stop();
            cashBuilderMusic.controls.stop();

            mySource.AmountCorrect = 0;
            amountLabelMain.Text = mySource.AmountCorrect.ToString();
            cashBuilderForm.SetAmountCorrectCB(mySource.AmountCorrect);

            mySource.TimeLeft = "1:00";
            timeLabelMain.Text = mySource.TimeLeft;
            cashBuilderForm.SetTimeLeftCB(mySource.TimeLeft);
        }

        // Increases Amount 
        private void increaseAmountButton_Click(object sender, EventArgs e) {
            mySource.AmountCorrect += 2;
            amountLabelMain.Text = mySource.AmountCorrect.ToString();
            cashBuilderForm.SetAmountCorrectCB(mySource.AmountCorrect);
        }

        // Increases Amount
        private void decreaseAmountButton_Click(object sender, EventArgs e) {
            mySource.AmountCorrect -= 2;
            amountLabelMain.Text = mySource.AmountCorrect.ToString();
            cashBuilderForm.SetAmountCorrectCB(mySource.AmountCorrect);
        }

        // --------------------------- END of Cash Builder Code ---------------------------

        // ------------------------ START OF CHASER VS PLAYER CODE  -----------------------






        // ------------------------- END OF CHASER VS PLAYER CODE  -----------------------


        // ------------------------ START OF FINAL CHASE CODE  -----------------------






        // ------------------------- END OF FINAL CHASE CODE  -----------------------

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
