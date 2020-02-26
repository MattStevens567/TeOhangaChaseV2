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
            this.cbTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabelCB = new System.Windows.Forms.Label();
            this.AmountLabelCB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTimer
            // 
            this.cbTimer.Tick += new System.EventHandler(this.cbTimer_Tick);
            // 
            // timeLabelCB
            // 
            this.timeLabelCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabelCB.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabelCB.Location = new System.Drawing.Point(883, 475);
            this.timeLabelCB.Name = "timeLabelCB";
            this.timeLabelCB.Size = new System.Drawing.Size(246, 111);
            this.timeLabelCB.TabIndex = 0;
            this.timeLabelCB.Text = "1:00";
            this.timeLabelCB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AmountLabelCB
            // 
            this.AmountLabelCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabelCB.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabelCB.Location = new System.Drawing.Point(218, 475);
            this.AmountLabelCB.Name = "AmountLabelCB";
            this.AmountLabelCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountLabelCB.Size = new System.Drawing.Size(174, 111);
            this.AmountLabelCB.TabIndex = 1;
            this.AmountLabelCB.Text = "$0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TeOhangaChaseV2.Properties.Resources.TeOhangaChaseGraphic;
            this.pictureBox1.Location = new System.Drawing.Point(332, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CashBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AmountLabelCB);
            this.Controls.Add(this.timeLabelCB);
            this.Name = "CashBuilderForm";
            this.Text = "CashBuilderForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashBuilderForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer cbTimer;
        private System.Windows.Forms.Label timeLabelCB;
        private System.Windows.Forms.Label AmountLabelCB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}