namespace JakubWoszczynaZad7
{
    partial class FormTicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.panelTicTacToe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.labelPlayTime = new System.Windows.Forms.Label();
            this.labelCountTime = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.pictureBoxO = new System.Windows.Forms.PictureBox();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTicTacToe
            // 
            this.panelTicTacToe.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTicTacToe.Location = new System.Drawing.Point(0, 0);
            this.panelTicTacToe.Name = "panelTicTacToe";
            this.panelTicTacToe.Size = new System.Drawing.Size(500, 500);
            this.panelTicTacToe.TabIndex = 0;
            this.panelTicTacToe.Click += new System.EventHandler(this.panelTicTacToe_Click);
            this.panelTicTacToe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTicTacToe_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twój znak:";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // labelPlayTime
            // 
            this.labelPlayTime.AutoSize = true;
            this.labelPlayTime.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayTime.Location = new System.Drawing.Point(512, 319);
            this.labelPlayTime.Name = "labelPlayTime";
            this.labelPlayTime.Size = new System.Drawing.Size(129, 21);
            this.labelPlayTime.TabIndex = 1;
            this.labelPlayTime.Text = "Czas rozgrywki:";
            // 
            // labelCountTime
            // 
            this.labelCountTime.AutoSize = true;
            this.labelCountTime.Font = new System.Drawing.Font("Playbill", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountTime.Location = new System.Drawing.Point(537, 357);
            this.labelCountTime.Name = "labelCountTime";
            this.labelCountTime.Size = new System.Drawing.Size(76, 98);
            this.labelCountTime.TabIndex = 2;
            this.labelCountTime.Text = "0";
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonRestart.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRestart.Location = new System.Drawing.Point(516, 265);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(125, 35);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // pictureBoxO
            // 
            this.pictureBoxO.Image = global::JakubWoszczynaZad7.Properties.Resources.o2;
            this.pictureBoxO.Location = new System.Drawing.Point(516, 88);
            this.pictureBoxO.Name = "pictureBoxO";
            this.pictureBoxO.Size = new System.Drawing.Size(137, 137);
            this.pictureBoxO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxO.TabIndex = 3;
            this.pictureBoxO.TabStop = false;
            this.pictureBoxO.Visible = false;
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Image = global::JakubWoszczynaZad7.Properties.Resources.x;
            this.pictureBoxX.Location = new System.Drawing.Point(515, 88);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(137, 137);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 0;
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.Visible = false;
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(664, 500);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelCountTime);
            this.Controls.Add(this.labelPlayTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTicTacToe);
            this.Controls.Add(this.pictureBoxO);
            this.Controls.Add(this.pictureBoxX);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 539);
            this.MinimumSize = new System.Drawing.Size(680, 539);
            this.Name = "FormTicTacToe";
            this.Text = "Kółko i Krzyżyk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTicTacToe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label labelPlayTime;
        private System.Windows.Forms.Label labelCountTime;
        protected System.Windows.Forms.PictureBox pictureBoxX;
        protected System.Windows.Forms.PictureBox pictureBoxO;
        private System.Windows.Forms.Button buttonRestart;
    }
}

