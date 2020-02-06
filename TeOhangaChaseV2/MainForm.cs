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
       

        WMPLib.WindowsMediaPlayer countDownMusic;
        WMPLib.WindowsMediaPlayer stopTheChase;
        WMPLib.WindowsMediaPlayer finalChaseChaserWins;
        WMPLib.WindowsMediaPlayer finalChasePlayerWins;
        WMPLib.WindowsMediaPlayer finalChaseChaserCorrect;
        WMPLib.WindowsMediaPlayer finalChasePlayerCorrect;
        WMPLib.WindowsMediaPlayer playerCorrect;
        WMPLib.WindowsMediaPlayer cashBuilderMusic;


        public MainForm() {
            InitializeComponent();
        }

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
            testLabel.Text = mMsLeft.ToString();
        }

        private void startTimerCB_Click(object sender, EventArgs e) {
            mMsLeft = 60000;
            mainTimer.Interval = 100;
            mainTimer.Start();
            mWatch.Start();

        }
    }
}
