namespace JakubWoszczynaZad1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelHeroes = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelMercury = new System.Windows.Forms.Label();
            this.labelJewels = new System.Windows.Forms.Label();
            this.labelCrystal = new System.Windows.Forms.Label();
            this.labelSulfur = new System.Windows.Forms.Label();
            this.labelStone = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.dataGridViewMines = new System.Windows.Forms.DataGridView();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonWood = new System.Windows.Forms.Button();
            this.buttonMercury = new System.Windows.Forms.Button();
            this.buttonStone = new System.Windows.Forms.Button();
            this.buttonSulfur = new System.Windows.Forms.Button();
            this.buttonCrystal = new System.Windows.Forms.Button();
            this.buttonJewels = new System.Windows.Forms.Button();
            this.buttonGold = new System.Windows.Forms.Button();
            this.dataGridViewHeroes = new System.Windows.Forms.DataGridView();
            this.NewHero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCastle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHero = new System.Windows.Forms.Button();
            this.buttonCastle = new System.Windows.Forms.Button();
            this.buttonGainWood = new System.Windows.Forms.Button();
            this.buttonGainMercury = new System.Windows.Forms.Button();
            this.buttonGainStone = new System.Windows.Forms.Button();
            this.buttonGainSulfur = new System.Windows.Forms.Button();
            this.buttonGainCrystal = new System.Windows.Forms.Button();
            this.buttonGainJewels = new System.Windows.Forms.Button();
            this.buttonGainGold = new System.Windows.Forms.Button();
            this.Mine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeroes
            // 
            this.labelHeroes.AutoSize = true;
            this.labelHeroes.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelHeroes.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeroes.Location = new System.Drawing.Point(256, 9);
            this.labelHeroes.Name = "labelHeroes";
            this.labelHeroes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHeroes.Size = new System.Drawing.Size(359, 74);
            this.labelHeroes.TabIndex = 0;
            this.labelHeroes.Text = "HEROES X";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Location = new System.Drawing.Point(2, 401);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(54, 13);
            this.labelWood.TabIndex = 1;
            this.labelWood.Text = "Wood: 10";
            // 
            // labelMercury
            // 
            this.labelMercury.AutoSize = true;
            this.labelMercury.Location = new System.Drawing.Point(83, 401);
            this.labelMercury.Name = "labelMercury";
            this.labelMercury.Size = new System.Drawing.Size(57, 13);
            this.labelMercury.TabIndex = 2;
            this.labelMercury.Text = "Mercury: 5";
            // 
            // labelJewels
            // 
            this.labelJewels.AutoSize = true;
            this.labelJewels.Location = new System.Drawing.Point(404, 401);
            this.labelJewels.Name = "labelJewels";
            this.labelJewels.Size = new System.Drawing.Size(51, 13);
            this.labelJewels.TabIndex = 3;
            this.labelJewels.Text = "Jewels: 3";
            // 
            // labelCrystal
            // 
            this.labelCrystal.AutoSize = true;
            this.labelCrystal.Location = new System.Drawing.Point(324, 401);
            this.labelCrystal.Name = "labelCrystal";
            this.labelCrystal.Size = new System.Drawing.Size(50, 13);
            this.labelCrystal.TabIndex = 4;
            this.labelCrystal.Text = "Crystal: 3";
            // 
            // labelSulfur
            // 
            this.labelSulfur.AutoSize = true;
            this.labelSulfur.Location = new System.Drawing.Point(245, 401);
            this.labelSulfur.Name = "labelSulfur";
            this.labelSulfur.Size = new System.Drawing.Size(46, 13);
            this.labelSulfur.TabIndex = 5;
            this.labelSulfur.Text = "Sulfur: 5";
            // 
            // labelStone
            // 
            this.labelStone.AutoSize = true;
            this.labelStone.Location = new System.Drawing.Point(164, 401);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(53, 13);
            this.labelStone.TabIndex = 6;
            this.labelStone.Text = "Stone: 10";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(482, 401);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(59, 13);
            this.labelGold.TabIndex = 7;
            this.labelGold.Text = "Gold: 1500";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(794, 401);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(40, 13);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "00 : 00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // dataGridViewMines
            // 
            this.dataGridViewMines.AllowUserToAddRows = false;
            this.dataGridViewMines.AllowUserToDeleteRows = false;
            this.dataGridViewMines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mine,
            this.number,
            this.unit,
            this.Cost});
            this.dataGridViewMines.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewMines.Name = "dataGridViewMines";
            this.dataGridViewMines.ReadOnly = true;
            this.dataGridViewMines.Size = new System.Drawing.Size(443, 197);
            this.dataGridViewMines.TabIndex = 10;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(673, 0);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 11;
            this.pictureBoxMap.TabStop = false;
            // 
            // buttonWood
            // 
            this.buttonWood.BackColor = System.Drawing.Color.Firebrick;
            this.buttonWood.Location = new System.Drawing.Point(5, 348);
            this.buttonWood.Name = "buttonWood";
            this.buttonWood.Size = new System.Drawing.Size(75, 50);
            this.buttonWood.TabIndex = 12;
            this.buttonWood.Text = "Buy lumbermill lvl 1";
            this.buttonWood.UseVisualStyleBackColor = false;
            this.buttonWood.Click += new System.EventHandler(this.buttonWood_Click);
            this.buttonWood.MouseLeave += new System.EventHandler(this.buttonWood_MouseLeave);
            this.buttonWood.MouseHover += new System.EventHandler(this.buttonWood_MouseHover);
            // 
            // buttonMercury
            // 
            this.buttonMercury.BackColor = System.Drawing.Color.Firebrick;
            this.buttonMercury.Location = new System.Drawing.Point(86, 348);
            this.buttonMercury.Name = "buttonMercury";
            this.buttonMercury.Size = new System.Drawing.Size(75, 50);
            this.buttonMercury.TabIndex = 13;
            this.buttonMercury.Text = "Buy mercury mine lvl 1";
            this.buttonMercury.UseVisualStyleBackColor = false;
            this.buttonMercury.Click += new System.EventHandler(this.buttonMercury_Click);
            this.buttonMercury.MouseLeave += new System.EventHandler(this.buttonMercury_MouseLeave);
            this.buttonMercury.MouseHover += new System.EventHandler(this.buttonMercury_MouseHover);
            // 
            // buttonStone
            // 
            this.buttonStone.BackColor = System.Drawing.Color.Firebrick;
            this.buttonStone.Location = new System.Drawing.Point(167, 348);
            this.buttonStone.Name = "buttonStone";
            this.buttonStone.Size = new System.Drawing.Size(75, 50);
            this.buttonStone.TabIndex = 14;
            this.buttonStone.Text = "Buy stone mine lvl 1";
            this.buttonStone.UseVisualStyleBackColor = false;
            this.buttonStone.Click += new System.EventHandler(this.buttonStone_Click);
            this.buttonStone.MouseLeave += new System.EventHandler(this.buttonStone_MouseLeave);
            this.buttonStone.MouseHover += new System.EventHandler(this.buttonStone_MouseHover);
            // 
            // buttonSulfur
            // 
            this.buttonSulfur.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSulfur.Location = new System.Drawing.Point(248, 348);
            this.buttonSulfur.Name = "buttonSulfur";
            this.buttonSulfur.Size = new System.Drawing.Size(75, 50);
            this.buttonSulfur.TabIndex = 15;
            this.buttonSulfur.Text = "Buy sulfur mine lvl 1";
            this.buttonSulfur.UseVisualStyleBackColor = false;
            this.buttonSulfur.Click += new System.EventHandler(this.buttonSulfur_Click);
            this.buttonSulfur.MouseLeave += new System.EventHandler(this.buttonSulfur_MouseLeave);
            this.buttonSulfur.MouseHover += new System.EventHandler(this.buttonSulfur_MouseHover);
            // 
            // buttonCrystal
            // 
            this.buttonCrystal.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCrystal.Location = new System.Drawing.Point(327, 348);
            this.buttonCrystal.Name = "buttonCrystal";
            this.buttonCrystal.Size = new System.Drawing.Size(74, 50);
            this.buttonCrystal.TabIndex = 16;
            this.buttonCrystal.Text = "Buy crystal mine lvl 1";
            this.buttonCrystal.UseVisualStyleBackColor = false;
            this.buttonCrystal.Click += new System.EventHandler(this.buttonCrystal_Click);
            this.buttonCrystal.MouseLeave += new System.EventHandler(this.buttonCrystal_MouseLeave);
            this.buttonCrystal.MouseHover += new System.EventHandler(this.buttonCrystal_MouseHover);
            // 
            // buttonJewels
            // 
            this.buttonJewels.BackColor = System.Drawing.Color.Firebrick;
            this.buttonJewels.Location = new System.Drawing.Point(407, 348);
            this.buttonJewels.Name = "buttonJewels";
            this.buttonJewels.Size = new System.Drawing.Size(72, 50);
            this.buttonJewels.TabIndex = 17;
            this.buttonJewels.Text = "Buy jewels mine lvl 1";
            this.buttonJewels.UseVisualStyleBackColor = false;
            this.buttonJewels.Click += new System.EventHandler(this.buttonJewels_Click);
            this.buttonJewels.MouseLeave += new System.EventHandler(this.buttonJewels_MouseLeave);
            this.buttonJewels.MouseHover += new System.EventHandler(this.buttonJewels_MouseHover);
            // 
            // buttonGold
            // 
            this.buttonGold.BackColor = System.Drawing.Color.Firebrick;
            this.buttonGold.Location = new System.Drawing.Point(485, 348);
            this.buttonGold.Name = "buttonGold";
            this.buttonGold.Size = new System.Drawing.Size(69, 50);
            this.buttonGold.TabIndex = 18;
            this.buttonGold.Text = "Buy gold mine lvl 1";
            this.buttonGold.UseVisualStyleBackColor = false;
            this.buttonGold.Click += new System.EventHandler(this.buttonGold_Click);
            this.buttonGold.MouseLeave += new System.EventHandler(this.buttonGold_MouseLeave);
            this.buttonGold.MouseHover += new System.EventHandler(this.buttonGold_MouseHover);
            // 
            // dataGridViewHeroes
            // 
            this.dataGridViewHeroes.AllowUserToAddRows = false;
            this.dataGridViewHeroes.AllowUserToDeleteRows = false;
            this.dataGridViewHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeroes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NewHero,
            this.NewCastle});
            this.dataGridViewHeroes.Location = new System.Drawing.Point(590, 245);
            this.dataGridViewHeroes.Name = "dataGridViewHeroes";
            this.dataGridViewHeroes.ReadOnly = true;
            this.dataGridViewHeroes.Size = new System.Drawing.Size(244, 153);
            this.dataGridViewHeroes.TabIndex = 19;
            // 
            // NewHero
            // 
            this.NewHero.HeaderText = "Hero";
            this.NewHero.Name = "NewHero";
            this.NewHero.ReadOnly = true;
            // 
            // NewCastle
            // 
            this.NewCastle.HeaderText = "Castle";
            this.NewCastle.Name = "NewCastle";
            this.NewCastle.ReadOnly = true;
            // 
            // buttonHero
            // 
            this.buttonHero.Location = new System.Drawing.Point(642, 216);
            this.buttonHero.Name = "buttonHero";
            this.buttonHero.Size = new System.Drawing.Size(75, 23);
            this.buttonHero.TabIndex = 20;
            this.buttonHero.Text = "Buy hero";
            this.buttonHero.UseVisualStyleBackColor = true;
            this.buttonHero.Click += new System.EventHandler(this.buttonHero_Click);
            // 
            // buttonCastle
            // 
            this.buttonCastle.Location = new System.Drawing.Point(738, 216);
            this.buttonCastle.Name = "buttonCastle";
            this.buttonCastle.Size = new System.Drawing.Size(75, 23);
            this.buttonCastle.TabIndex = 21;
            this.buttonCastle.Text = "Buy castle";
            this.buttonCastle.UseVisualStyleBackColor = true;
            this.buttonCastle.Click += new System.EventHandler(this.buttonCastle_Click);
            // 
            // buttonGainWood
            // 
            this.buttonGainWood.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainWood.Location = new System.Drawing.Point(13, 13);
            this.buttonGainWood.Name = "buttonGainWood";
            this.buttonGainWood.Size = new System.Drawing.Size(51, 35);
            this.buttonGainWood.TabIndex = 22;
            this.buttonGainWood.Text = "Gain wood";
            this.buttonGainWood.UseVisualStyleBackColor = false;
            this.buttonGainWood.Click += new System.EventHandler(this.buttonGainWood_Click);
            // 
            // buttonGainMercury
            // 
            this.buttonGainMercury.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainMercury.Location = new System.Drawing.Point(70, 13);
            this.buttonGainMercury.Name = "buttonGainMercury";
            this.buttonGainMercury.Size = new System.Drawing.Size(53, 35);
            this.buttonGainMercury.TabIndex = 23;
            this.buttonGainMercury.Text = "Gain mercury";
            this.buttonGainMercury.UseVisualStyleBackColor = false;
            this.buttonGainMercury.Click += new System.EventHandler(this.buttonGainMercury_Click);
            // 
            // buttonGainStone
            // 
            this.buttonGainStone.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainStone.Location = new System.Drawing.Point(127, 13);
            this.buttonGainStone.Name = "buttonGainStone";
            this.buttonGainStone.Size = new System.Drawing.Size(51, 35);
            this.buttonGainStone.TabIndex = 24;
            this.buttonGainStone.Text = "Gain stone";
            this.buttonGainStone.UseVisualStyleBackColor = false;
            this.buttonGainStone.Click += new System.EventHandler(this.buttonGainStone_Click);
            // 
            // buttonGainSulfur
            // 
            this.buttonGainSulfur.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainSulfur.Location = new System.Drawing.Point(184, 13);
            this.buttonGainSulfur.Name = "buttonGainSulfur";
            this.buttonGainSulfur.Size = new System.Drawing.Size(51, 35);
            this.buttonGainSulfur.TabIndex = 25;
            this.buttonGainSulfur.Text = "Gain sulfur";
            this.buttonGainSulfur.UseVisualStyleBackColor = false;
            this.buttonGainSulfur.Click += new System.EventHandler(this.buttonGainSulfur_Click);
            // 
            // buttonGainCrystal
            // 
            this.buttonGainCrystal.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainCrystal.Location = new System.Drawing.Point(47, 54);
            this.buttonGainCrystal.Name = "buttonGainCrystal";
            this.buttonGainCrystal.Size = new System.Drawing.Size(51, 35);
            this.buttonGainCrystal.TabIndex = 26;
            this.buttonGainCrystal.Text = "Gain crystal";
            this.buttonGainCrystal.UseVisualStyleBackColor = false;
            this.buttonGainCrystal.Click += new System.EventHandler(this.buttonGainCrystal_Click);
            // 
            // buttonGainJewels
            // 
            this.buttonGainJewels.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainJewels.Location = new System.Drawing.Point(104, 54);
            this.buttonGainJewels.Name = "buttonGainJewels";
            this.buttonGainJewels.Size = new System.Drawing.Size(51, 35);
            this.buttonGainJewels.TabIndex = 27;
            this.buttonGainJewels.Text = "Gain jewels";
            this.buttonGainJewels.UseVisualStyleBackColor = false;
            this.buttonGainJewels.Click += new System.EventHandler(this.buttonGainJewels_Click);
            // 
            // buttonGainGold
            // 
            this.buttonGainGold.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGainGold.Location = new System.Drawing.Point(161, 54);
            this.buttonGainGold.Name = "buttonGainGold";
            this.buttonGainGold.Size = new System.Drawing.Size(51, 35);
            this.buttonGainGold.TabIndex = 28;
            this.buttonGainGold.Text = "Gain gold";
            this.buttonGainGold.UseVisualStyleBackColor = false;
            this.buttonGainGold.Click += new System.EventHandler(this.buttonGainGold_Click);
            // 
            // Mine
            // 
            this.Mine.HeaderText = "Mine";
            this.Mine.Name = "Mine";
            this.Mine.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Seconds/unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelUserName.Location = new System.Drawing.Point(338, 87);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(160, 25);
            this.labelUserName.TabIndex = 29;
            this.labelUserName.Text = "labelUserName";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(839, 416);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonGainGold);
            this.Controls.Add(this.buttonGainJewels);
            this.Controls.Add(this.buttonGainCrystal);
            this.Controls.Add(this.buttonGainSulfur);
            this.Controls.Add(this.buttonGainStone);
            this.Controls.Add(this.buttonGainMercury);
            this.Controls.Add(this.buttonGainWood);
            this.Controls.Add(this.buttonCastle);
            this.Controls.Add(this.buttonHero);
            this.Controls.Add(this.dataGridViewHeroes);
            this.Controls.Add(this.buttonGold);
            this.Controls.Add(this.buttonJewels);
            this.Controls.Add(this.buttonCrystal);
            this.Controls.Add(this.buttonSulfur);
            this.Controls.Add(this.buttonStone);
            this.Controls.Add(this.buttonMercury);
            this.Controls.Add(this.buttonWood);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.dataGridViewMines);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelStone);
            this.Controls.Add(this.labelSulfur);
            this.Controls.Add(this.labelCrystal);
            this.Controls.Add(this.labelJewels);
            this.Controls.Add(this.labelMercury);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelHeroes);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeroes;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelMercury;
        private System.Windows.Forms.Label labelJewels;
        private System.Windows.Forms.Label labelCrystal;
        private System.Windows.Forms.Label labelSulfur;
        private System.Windows.Forms.Label labelStone;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.DataGridView dataGridViewMines;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonWood;
        private System.Windows.Forms.Button buttonMercury;
        private System.Windows.Forms.Button buttonStone;
        private System.Windows.Forms.Button buttonSulfur;
        private System.Windows.Forms.Button buttonCrystal;
        private System.Windows.Forms.Button buttonJewels;
        private System.Windows.Forms.Button buttonGold;
        private System.Windows.Forms.DataGridView dataGridViewHeroes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewHero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCastle;
        private System.Windows.Forms.Button buttonHero;
        private System.Windows.Forms.Button buttonCastle;
        private System.Windows.Forms.Button buttonGainWood;
        private System.Windows.Forms.Button buttonGainMercury;
        private System.Windows.Forms.Button buttonGainStone;
        private System.Windows.Forms.Button buttonGainSulfur;
        private System.Windows.Forms.Button buttonGainCrystal;
        private System.Windows.Forms.Button buttonGainJewels;
        private System.Windows.Forms.Button buttonGainGold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mine;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Label labelUserName;
    }
}

