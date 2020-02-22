namespace TeOhangaChaseV2 {
    partial class CashBuilderForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.testLabel = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(354, 180);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            // 
            // cbTimer
            // 
            this.cbTimer.Tick += new System.EventHandler(this.cbTimer_Tick);
            // 
            // CashBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testLabel);
            this.Name = "CashBuilderForm";
            this.Text = "CashBuilderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer cbTimer;
        private System.Windows.Forms.Label testLabel;
    }
}