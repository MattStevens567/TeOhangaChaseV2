﻿namespace TeOhangaChaseV2 {
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
            this.CBTestLabel = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBTestLabel
            // 
            this.CBTestLabel.AutoSize = true;
            this.CBTestLabel.Location = new System.Drawing.Point(354, 180);
            this.CBTestLabel.Name = "CBTestLabel";
            this.CBTestLabel.Size = new System.Drawing.Size(35, 13);
            this.CBTestLabel.TabIndex = 0;
            this.CBTestLabel.Text = "label1";
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
            this.Controls.Add(this.CBTestLabel);
            this.Name = "CashBuilderForm";
            this.Text = "CashBuilderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CBTestLabel;
        private System.Windows.Forms.Timer cbTimer;
    }
}