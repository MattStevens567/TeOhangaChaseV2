namespace TeOhangaChaseV2 {
    partial class MainForm {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cashBuilderTab = new System.Windows.Forms.TabPage();
            this.decreaseAmountButton = new System.Windows.Forms.Button();
            this.increaseAmountButton = new System.Windows.Forms.Button();
            this.amountLabelMain = new System.Windows.Forms.Label();
            this.resetGameCB = new System.Windows.Forms.Button();
            this.startTimerCB = new System.Windows.Forms.Button();
            this.timeLabelMain = new System.Windows.Forms.Label();
            this.launchCashBuilder = new System.Windows.Forms.Button();
            this.chaserVsPlayerTab = new System.Windows.Forms.TabPage();
            this.finalChaseTab = new System.Windows.Forms.TabPage();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.chaserCorrectButton = new System.Windows.Forms.Button();
            this.playerCorrectButton = new System.Windows.Forms.Button();
            this.revealAnswerButton = new System.Windows.Forms.Button();
            this.decreasePlayerButton = new System.Windows.Forms.Button();
            this.decreaseChaserButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.cashBuilderTab.SuspendLayout();
            this.chaserVsPlayerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cashBuilderTab);
            this.tabControl1.Controls.Add(this.chaserVsPlayerTab);
            this.tabControl1.Controls.Add(this.finalChaseTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // cashBuilderTab
            // 
            this.cashBuilderTab.Controls.Add(this.decreaseAmountButton);
            this.cashBuilderTab.Controls.Add(this.increaseAmountButton);
            this.cashBuilderTab.Controls.Add(this.amountLabelMain);
            this.cashBuilderTab.Controls.Add(this.resetGameCB);
            this.cashBuilderTab.Controls.Add(this.startTimerCB);
            this.cashBuilderTab.Controls.Add(this.timeLabelMain);
            this.cashBuilderTab.Controls.Add(this.launchCashBuilder);
            this.cashBuilderTab.Location = new System.Drawing.Point(4, 22);
            this.cashBuilderTab.Name = "cashBuilderTab";
            this.cashBuilderTab.Padding = new System.Windows.Forms.Padding(3);
            this.cashBuilderTab.Size = new System.Drawing.Size(768, 400);
            this.cashBuilderTab.TabIndex = 0;
            this.cashBuilderTab.Text = "Cash Builder";
            this.cashBuilderTab.UseVisualStyleBackColor = true;
            // 
            // decreaseAmountButton
            // 
            this.decreaseAmountButton.Location = new System.Drawing.Point(316, 210);
            this.decreaseAmountButton.Name = "decreaseAmountButton";
            this.decreaseAmountButton.Size = new System.Drawing.Size(107, 23);
            this.decreaseAmountButton.TabIndex = 6;
            this.decreaseAmountButton.Text = "Decrease Amount";
            this.decreaseAmountButton.UseVisualStyleBackColor = true;
            this.decreaseAmountButton.Click += new System.EventHandler(this.decreaseAmountButton_Click);
            // 
            // increaseAmountButton
            // 
            this.increaseAmountButton.Location = new System.Drawing.Point(316, 151);
            this.increaseAmountButton.Name = "increaseAmountButton";
            this.increaseAmountButton.Size = new System.Drawing.Size(107, 23);
            this.increaseAmountButton.TabIndex = 5;
            this.increaseAmountButton.Text = "Increase Amount";
            this.increaseAmountButton.UseVisualStyleBackColor = true;
            this.increaseAmountButton.Click += new System.EventHandler(this.increaseAmountButton_Click);
            // 
            // amountLabelMain
            // 
            this.amountLabelMain.AutoSize = true;
            this.amountLabelMain.Location = new System.Drawing.Point(141, 215);
            this.amountLabelMain.Name = "amountLabelMain";
            this.amountLabelMain.Size = new System.Drawing.Size(42, 13);
            this.amountLabelMain.TabIndex = 4;
            this.amountLabelMain.Text = "amount";
            // 
            // resetGameCB
            // 
            this.resetGameCB.Location = new System.Drawing.Point(532, 210);
            this.resetGameCB.Name = "resetGameCB";
            this.resetGameCB.Size = new System.Drawing.Size(103, 23);
            this.resetGameCB.TabIndex = 3;
            this.resetGameCB.Text = "Stop/Reset Game";
            this.resetGameCB.UseVisualStyleBackColor = true;
            this.resetGameCB.Click += new System.EventHandler(this.resetGameCB_Click);
            // 
            // startTimerCB
            // 
            this.startTimerCB.Location = new System.Drawing.Point(532, 151);
            this.startTimerCB.Name = "startTimerCB";
            this.startTimerCB.Size = new System.Drawing.Size(103, 23);
            this.startTimerCB.TabIndex = 2;
            this.startTimerCB.Text = "Start Timer";
            this.startTimerCB.UseVisualStyleBackColor = true;
            this.startTimerCB.Click += new System.EventHandler(this.startTimerCB_Click);
            // 
            // timeLabelMain
            // 
            this.timeLabelMain.AutoSize = true;
            this.timeLabelMain.Location = new System.Drawing.Point(122, 151);
            this.timeLabelMain.Name = "timeLabelMain";
            this.timeLabelMain.Size = new System.Drawing.Size(80, 13);
            this.timeLabelMain.TabIndex = 1;
            this.timeLabelMain.Text = "Stopwatch time";
            // 
            // launchCashBuilder
            // 
            this.launchCashBuilder.Location = new System.Drawing.Point(241, 308);
            this.launchCashBuilder.Name = "launchCashBuilder";
            this.launchCashBuilder.Size = new System.Drawing.Size(252, 23);
            this.launchCashBuilder.TabIndex = 0;
            this.launchCashBuilder.Text = "Launch Cash Builder";
            this.launchCashBuilder.UseVisualStyleBackColor = true;
            this.launchCashBuilder.Click += new System.EventHandler(this.launchCashBuilder_Click);
            // 
            // chaserVsPlayerTab
            // 
            this.chaserVsPlayerTab.Controls.Add(this.decreaseChaserButton);
            this.chaserVsPlayerTab.Controls.Add(this.decreasePlayerButton);
            this.chaserVsPlayerTab.Controls.Add(this.revealAnswerButton);
            this.chaserVsPlayerTab.Controls.Add(this.playerCorrectButton);
            this.chaserVsPlayerTab.Controls.Add(this.chaserCorrectButton);
            this.chaserVsPlayerTab.Location = new System.Drawing.Point(4, 22);
            this.chaserVsPlayerTab.Name = "chaserVsPlayerTab";
            this.chaserVsPlayerTab.Size = new System.Drawing.Size(768, 400);
            this.chaserVsPlayerTab.TabIndex = 2;
            this.chaserVsPlayerTab.Text = "Chaser vs. Player";
            this.chaserVsPlayerTab.UseVisualStyleBackColor = true;
            // 
            // finalChaseTab
            // 
            this.finalChaseTab.Location = new System.Drawing.Point(4, 22);
            this.finalChaseTab.Name = "finalChaseTab";
            this.finalChaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.finalChaseTab.Size = new System.Drawing.Size(768, 400);
            this.finalChaseTab.TabIndex = 1;
            this.finalChaseTab.Text = "Final Chase";
            this.finalChaseTab.UseVisualStyleBackColor = true;
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // chaserCorrectButton
            // 
            this.chaserCorrectButton.Location = new System.Drawing.Point(109, 174);
            this.chaserCorrectButton.Name = "chaserCorrectButton";
            this.chaserCorrectButton.Size = new System.Drawing.Size(114, 23);
            this.chaserCorrectButton.TabIndex = 0;
            this.chaserCorrectButton.Text = "Chaser Correct";
            this.chaserCorrectButton.UseVisualStyleBackColor = true;
            // 
            // playerCorrectButton
            // 
            this.playerCorrectButton.Location = new System.Drawing.Point(109, 88);
            this.playerCorrectButton.Name = "playerCorrectButton";
            this.playerCorrectButton.Size = new System.Drawing.Size(114, 23);
            this.playerCorrectButton.TabIndex = 1;
            this.playerCorrectButton.Text = "Player Correct";
            this.playerCorrectButton.UseVisualStyleBackColor = true;
            // 
            // revealAnswerButton
            // 
            this.revealAnswerButton.Location = new System.Drawing.Point(109, 262);
            this.revealAnswerButton.Name = "revealAnswerButton";
            this.revealAnswerButton.Size = new System.Drawing.Size(114, 23);
            this.revealAnswerButton.TabIndex = 2;
            this.revealAnswerButton.Text = "Reveal Answer";
            this.revealAnswerButton.UseVisualStyleBackColor = true;
            // 
            // decreasePlayerButton
            // 
            this.decreasePlayerButton.Location = new System.Drawing.Point(0, 345);
            this.decreasePlayerButton.Name = "decreasePlayerButton";
            this.decreasePlayerButton.Size = new System.Drawing.Size(99, 23);
            this.decreasePlayerButton.TabIndex = 3;
            this.decreasePlayerButton.Text = "Decrease Player";
            this.decreasePlayerButton.UseVisualStyleBackColor = true;
            // 
            // decreaseChaserButton
            // 
            this.decreaseChaserButton.Location = new System.Drawing.Point(0, 376);
            this.decreaseChaserButton.Name = "decreaseChaserButton";
            this.decreaseChaserButton.Size = new System.Drawing.Size(99, 23);
            this.decreaseChaserButton.TabIndex = 4;
            this.decreaseChaserButton.Text = "Decrease Chaser";
            this.decreaseChaserButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Te Ohanga Chase Main Page";
            this.tabControl1.ResumeLayout(false);
            this.cashBuilderTab.ResumeLayout(false);
            this.cashBuilderTab.PerformLayout();
            this.chaserVsPlayerTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cashBuilderTab;
        private System.Windows.Forms.TabPage finalChaseTab;
        private System.Windows.Forms.TabPage chaserVsPlayerTab;
        private System.Windows.Forms.Button launchCashBuilder;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label timeLabelMain;
        private System.Windows.Forms.Button startTimerCB;
        private System.Windows.Forms.Button resetGameCB;
        private System.Windows.Forms.Button decreaseAmountButton;
        private System.Windows.Forms.Button increaseAmountButton;
        private System.Windows.Forms.Label amountLabelMain;
        private System.Windows.Forms.Button decreaseChaserButton;
        private System.Windows.Forms.Button decreasePlayerButton;
        private System.Windows.Forms.Button revealAnswerButton;
        private System.Windows.Forms.Button playerCorrectButton;
        private System.Windows.Forms.Button chaserCorrectButton;
    }
}

