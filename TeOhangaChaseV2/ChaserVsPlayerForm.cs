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
    public partial class ChaserVsPlayerForm : Form {
        public int PlayerScoreCVP { get; set; }
        public int ChaserScoreCVP { get; set; }

        


        public ChaserVsPlayerForm() {
            InitializeComponent();
        }

        public void OnLoad(object sender, EventArgs e) {

        }


        public void ChaserVsPlayer_Paint(object sender, PaintEventArgs e) {
            Pen pen = new Pen(Color.Black, 2);
            pen.Alignment = PenAlignment.Inset;
            int counterHeight = 150;
            int anchorX = 10;
            int anchorY = (this.Height / 2) + 150;
            int counterWidth = ((this.Width - 20) - (5 * (DataClass.PlayerScoreCVP))) / DataClass.mFinalPlayerScore;
            //Console.WriteLine(counterHeight);
            //Console.WriteLine(anchorX);
            //Console.WriteLine(anchorY);
            //Console.WriteLine(counterWidth);

            Graphics graphics = e.Graphics;

            for (int i = 0; i < DataClass.mFinalPlayerScore; i++) {

                if (i < DataClass.mChaserScore) {

                    graphics.FillRectangle(Brushes.Red, anchorX + ((counterWidth + 5) * i), anchorY, counterWidth, counterHeight);
                } else {
                    graphics.FillRectangle(Brushes.Cyan, anchorX + ((counterWidth + 5) * i), anchorY, counterWidth, counterHeight);
                }
                Rectangle rect = new Rectangle(anchorX + ((counterWidth + 5) * i), anchorY, counterWidth, counterHeight);
                graphics.DrawRectangle(pen, rect);
                // Draws numbers over points
                Font font = new Font("Arial", 20);
                graphics.DrawString((i + 1).ToString(), font, Brushes.Black, anchorX + ((counterWidth + 5) * i), anchorY);

            }
        }

        private void cvpTimer_Tick(object sender, EventArgs e) {

        }
    }
}
