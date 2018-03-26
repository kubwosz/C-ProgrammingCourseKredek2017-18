namespace JakubWoszczynaZad7
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlayTicTacToe = new System.Windows.Forms.Button();
            this.buttonPlayPlatform = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonScores = new System.Windows.Forms.Button();
            this.buttonDropDown = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonInvadersGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome \r\nto \r\nMultigame Center!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlayTicTacToe
            // 
            this.buttonPlayTicTacToe.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPlayTicTacToe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayTicTacToe.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayTicTacToe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlayTicTacToe.Location = new System.Drawing.Point(141, 196);
            this.buttonPlayTicTacToe.Name = "buttonPlayTicTacToe";
            this.buttonPlayTicTacToe.Size = new System.Drawing.Size(344, 47);
            this.buttonPlayTicTacToe.TabIndex = 1;
            this.buttonPlayTicTacToe.Text = "Zagraj w \r\nkółko i krzyżyk";
            this.buttonPlayTicTacToe.UseVisualStyleBackColor = false;
            this.buttonPlayTicTacToe.Click += new System.EventHandler(this.buttonPlayTicTacToe_Click);
            // 
            // buttonPlayPlatform
            // 
            this.buttonPlayPlatform.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPlayPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayPlatform.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayPlatform.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPlayPlatform.Location = new System.Drawing.Point(141, 304);
            this.buttonPlayPlatform.Name = "buttonPlayPlatform";
            this.buttonPlayPlatform.Size = new System.Drawing.Size(344, 47);
            this.buttonPlayPlatform.TabIndex = 2;
            this.buttonPlayPlatform.Text = "Zagraj w \r\ngrę platformową";
            this.buttonPlayPlatform.UseVisualStyleBackColor = false;
            this.buttonPlayPlatform.Click += new System.EventHandler(this.buttonPlayPlatform_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonHelp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp.Location = new System.Drawing.Point(141, 520);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(344, 47);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Pomoc";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonRules.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRules.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRules.Location = new System.Drawing.Point(141, 412);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(344, 47);
            this.buttonRules.TabIndex = 4;
            this.buttonRules.Text = "Zasady";
            this.buttonRules.UseVisualStyleBackColor = false;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonScores
            // 
            this.buttonScores.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonScores.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonScores.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonScores.Location = new System.Drawing.Point(141, 466);
            this.buttonScores.Name = "buttonScores";
            this.buttonScores.Size = new System.Drawing.Size(344, 47);
            this.buttonScores.TabIndex = 5;
            this.buttonScores.Text = "Wyniki";
            this.buttonScores.UseVisualStyleBackColor = false;
            this.buttonScores.Click += new System.EventHandler(this.buttonScores_Click);
            // 
            // buttonDropDown
            // 
            this.buttonDropDown.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDropDown.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDropDown.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDropDown.Location = new System.Drawing.Point(141, 358);
            this.buttonDropDown.Name = "buttonDropDown";
            this.buttonDropDown.Size = new System.Drawing.Size(344, 47);
            this.buttonDropDown.TabIndex = 6;
            this.buttonDropDown.Text = "Zagraj w\r\ngrę Dropdown";
            this.buttonDropDown.UseVisualStyleBackColor = false;
            this.buttonDropDown.Click += new System.EventHandler(this.buttonDropDown_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerName.Location = new System.Drawing.Point(188, 9);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(247, 39);
            this.labelPlayerName.TabIndex = 7;
            this.labelPlayerName.Text = "labelPlayerName";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInvadersGame
            // 
            this.buttonInvadersGame.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonInvadersGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvadersGame.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInvadersGame.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInvadersGame.Location = new System.Drawing.Point(141, 250);
            this.buttonInvadersGame.Name = "buttonInvadersGame";
            this.buttonInvadersGame.Size = new System.Drawing.Size(344, 47);
            this.buttonInvadersGame.TabIndex = 8;
            this.buttonInvadersGame.Text = "Zagraj w \r\ngrę Invaders";
            this.buttonInvadersGame.UseVisualStyleBackColor = false;
            this.buttonInvadersGame.Click += new System.EventHandler(this.buttonInvadersGame_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(652, 597);
            this.Controls.Add(this.buttonInvadersGame);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.buttonDropDown);
            this.Controls.Add(this.buttonScores);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonPlayPlatform);
            this.Controls.Add(this.buttonPlayTicTacToe);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlayTicTacToe;
        private System.Windows.Forms.Button buttonPlayPlatform;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonScores;
        private System.Windows.Forms.Button buttonDropDown;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonInvadersGame;
    }
}