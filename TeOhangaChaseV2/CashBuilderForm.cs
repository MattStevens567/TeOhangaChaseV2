using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeOhangaChaseV2 {
    public partial class CashBuilderForm : Form {
        private static CashBuilderForm currentForm = null;

        private int AmountCorrectCB { get; set; }
        private string TimeLeftCB { get; set; }

     


        public CashBuilderForm() {
            if (currentForm != null) {
                currentForm.Close();
            }
            currentForm = this;
            InitializeComponent();
            Console.WriteLine("Running on Thread" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            TimeLeftCB = "1:00";
            AmountCorrectCB = 0;
        }

        public void OnLoad(object sender, EventArgs e) {
            cbTimer.Interval = 100;
            cbTimer.Start();

        }

        public void SetTimeLeftCB(string value) {
            TimeLeftCB = value;
        }

        public void SetAmountCorrectCB(int value) {
            AmountCorrectCB = value;
        }

        private void cbTimer_Tick(object sender, EventArgs e) {
            //Console.WriteLine("Running on Thread in TimerTick" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            timeLabelCB.Text = TimeLeftCB;
            AmountLabelCB.Text = "$" + AmountCorrectCB.ToString();

        }

        // ---------------- FullScreen Code -------------------------
        private void CashBuilderForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F11) {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
            if (e.KeyCode == Keys.Escape) {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }


    }
}
