namespace TicTacToe.View
{
    partial class TicTacToeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.learningTab = new System.Windows.Forms.TabPage();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbBlank = new System.Windows.Forms.Label();
            this.lbCircle = new System.Windows.Forms.Label();
            this.lbCross = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.pbBlank = new System.Windows.Forms.PictureBox();
            this.pbCircle = new System.Windows.Forms.PictureBox();
            this.pbCross = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.learningTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.gameTab);
            this.tabControl.Controls.Add(this.learningTab);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 585);
            this.tabControl.TabIndex = 0;
            // 
            // gameTab
            // 
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(570, 559);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // learningTab
            // 
            this.learningTab.BackColor = System.Drawing.Color.LightGray;
            this.learningTab.Controls.Add(this.lbResult);
            this.learningTab.Controls.Add(this.lbTest);
            this.learningTab.Controls.Add(this.lbBlank);
            this.learningTab.Controls.Add(this.lbCircle);
            this.learningTab.Controls.Add(this.lbCross);
            this.learningTab.Controls.Add(this.pbResult);
            this.learningTab.Controls.Add(this.pbTest);
            this.learningTab.Controls.Add(this.pbBlank);
            this.learningTab.Controls.Add(this.pbCircle);
            this.learningTab.Controls.Add(this.pbCross);
            this.learningTab.Location = new System.Drawing.Point(4, 22);
            this.learningTab.Name = "learningTab";
            this.learningTab.Padding = new System.Windows.Forms.Padding(3);
            this.learningTab.Size = new System.Drawing.Size(570, 559);
            this.learningTab.TabIndex = 1;
            this.learningTab.Text = "Learning";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(185, 326);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 9;
            this.lbResult.Text = "Result";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(73, 326);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(28, 13);
            this.lbTest.TabIndex = 8;
            this.lbTest.Text = "Test";
            // 
            // lbBlank
            // 
            this.lbBlank.AutoSize = true;
            this.lbBlank.Location = new System.Drawing.Point(272, 22);
            this.lbBlank.Name = "lbBlank";
            this.lbBlank.Size = new System.Drawing.Size(64, 13);
            this.lbBlank.TabIndex = 7;
            this.lbBlank.Text = "Blank [ 0 0 ]";
            // 
            // lbCircle
            // 
            this.lbCircle.AutoSize = true;
            this.lbCircle.Location = new System.Drawing.Point(172, 22);
            this.lbCircle.Name = "lbCircle";
            this.lbCircle.Size = new System.Drawing.Size(63, 13);
            this.lbCircle.TabIndex = 6;
            this.lbCircle.Text = "Circle [ 0 1 ]";
            // 
            // lbCross
            // 
            this.lbCross.AutoSize = true;
            this.lbCross.Location = new System.Drawing.Point(63, 22);
            this.lbCross.Name = "lbCross";
            this.lbCross.Size = new System.Drawing.Size(63, 13);
            this.lbCross.TabIndex = 5;
            this.lbCross.Text = "Cross [ 1 0 ]";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.White;
            this.pbResult.Location = new System.Drawing.Point(150, 342);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(100, 100);
            this.pbResult.TabIndex = 4;
            this.pbResult.TabStop = false;
            // 
            // pbTest
            // 
            this.pbTest.BackColor = System.Drawing.Color.White;
            this.pbTest.Location = new System.Drawing.Point(44, 342);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(100, 100);
            this.pbTest.TabIndex = 3;
            this.pbTest.TabStop = false;
            this.pbTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseDown);
            this.pbTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseMove);
            this.pbTest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseUp);
            // 
            // pbBlank
            // 
            this.pbBlank.BackColor = System.Drawing.Color.White;
            this.pbBlank.Location = new System.Drawing.Point(256, 38);
            this.pbBlank.Name = "pbBlank";
            this.pbBlank.Size = new System.Drawing.Size(100, 100);
            this.pbBlank.TabIndex = 2;
            this.pbBlank.TabStop = false;
            this.pbBlank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseDown);
            this.pbBlank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseMove);
            this.pbBlank.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseUp);
            // 
            // pbCircle
            // 
            this.pbCircle.BackColor = System.Drawing.Color.White;
            this.pbCircle.Location = new System.Drawing.Point(150, 38);
            this.pbCircle.Name = "pbCircle";
            this.pbCircle.Size = new System.Drawing.Size(100, 100);
            this.pbCircle.TabIndex = 1;
            this.pbCircle.TabStop = false;
            this.pbCircle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseDown);
            this.pbCircle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseMove);
            this.pbCircle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseUp);
            // 
            // pbCross
            // 
            this.pbCross.BackColor = System.Drawing.Color.White;
            this.pbCross.Location = new System.Drawing.Point(44, 38);
            this.pbCross.Name = "pbCross";
            this.pbCross.Size = new System.Drawing.Size(100, 100);
            this.pbCross.TabIndex = 0;
            this.pbCross.TabStop = false;
            this.pbCross.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseDown);
            this.pbCross.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseMove);
            this.pbCross.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLearning_MouseUp);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 583);
            this.Controls.Add(this.tabControl);
            this.Name = "TicTacToeForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.learningTab.ResumeLayout(false);
            this.learningTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.TabPage learningTab;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.PictureBox pbBlank;
        private System.Windows.Forms.PictureBox pbCircle;
        private System.Windows.Forms.PictureBox pbCross;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbBlank;
        private System.Windows.Forms.Label lbCircle;
        private System.Windows.Forms.Label lbCross;
    }
}

