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

        public void SetTestLabel(string value) {
            Console.WriteLine(value);
            testLabel.Text = value;
        } 


        public CashBuilderForm() {
            InitializeComponent();

        }

        private void cbTimer_Tick(object sender, EventArgs e) {


        }


    }
}
