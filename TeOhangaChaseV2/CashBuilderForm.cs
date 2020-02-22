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
        public CashBuilderForm() {
            InitializeComponent();

        }

        public CashBuilderForm(string test) {
            InitializeComponent();
            CBTestLabel.Text = test;
        }

        private void cbTimer_Tick(object sender, EventArgs e) {
        }


    }
}
