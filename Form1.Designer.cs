
namespace RaceGameAmrit
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vickyBet = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.gouravBet = new System.Windows.Forms.Label();
            this.aviBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.betting = new System.Windows.Forms.Button();
            this.VickyButton = new System.Windows.Forms.RadioButton();
            this.GouravButton = new System.Windows.Forms.RadioButton();
            this.AviButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racer4 = new System.Windows.Forms.PictureBox();
            this.racer3 = new System.Windows.Forms.PictureBox();
            this.racer2 = new System.Windows.Forms.PictureBox();
            this.racer1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.vickyBet);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.gouravBet);
            this.groupBox1.Controls.Add(this.aviBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.carNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.betting);
            this.groupBox1.Controls.Add(this.VickyButton);
            this.groupBox1.Controls.Add(this.GouravButton);
            this.groupBox1.Controls.Add(this.AviButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(16, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(757, 263);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet Here";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // vickyBet
            // 
            this.vickyBet.BackColor = System.Drawing.SystemColors.Window;
            this.vickyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vickyBet.ForeColor = System.Drawing.Color.Black;
            this.vickyBet.Location = new System.Drawing.Point(107, 121);
            this.vickyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vickyBet.Name = "vickyBet";
            this.vickyBet.Size = new System.Drawing.Size(257, 20);
            this.vickyBet.TabIndex = 13;
            this.vickyBet.Text = "Vicky Information";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Yellow;
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(571, 74);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(99, 37);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // gouravBet
            // 
            this.gouravBet.BackColor = System.Drawing.Color.White;
            this.gouravBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gouravBet.ForeColor = System.Drawing.Color.Black;
            this.gouravBet.Location = new System.Drawing.Point(107, 91);
            this.gouravBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gouravBet.Name = "gouravBet";
            this.gouravBet.Size = new System.Drawing.Size(257, 20);
            this.gouravBet.TabIndex = 12;
            this.gouravBet.Text = "Gourav information";
            // 
            // aviBet
            // 
            this.aviBet.BackColor = System.Drawing.Color.White;
            this.aviBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aviBet.ForeColor = System.Drawing.Color.Black;
            this.aviBet.Location = new System.Drawing.Point(107, 62);
            this.aviBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aviBet.Name = "aviBet";
            this.aviBet.Size = new System.Drawing.Size(257, 20);
            this.aviBet.TabIndex = 11;
            this.aviBet.Text = "Avi Infomation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // carNumber
            // 
            this.carNumber.BackColor = System.Drawing.SystemColors.Window;
            this.carNumber.Location = new System.Drawing.Point(571, 23);
            this.carNumber.Margin = new System.Windows.Forms.Padding(4);
            this.carNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.carNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carNumber.Name = "carNumber";
            this.carNumber.Size = new System.Drawing.Size(85, 22);
            this.carNumber.TabIndex = 8;
            this.carNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(469, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Car number";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(292, 20);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(84, 22);
            this.Amount.TabIndex = 6;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betting
            // 
            this.betting.BackColor = System.Drawing.Color.Crimson;
            this.betting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.betting.FlatAppearance.BorderSize = 5;
            this.betting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betting.Location = new System.Drawing.Point(473, 70);
            this.betting.Margin = new System.Windows.Forms.Padding(4);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(61, 41);
            this.betting.TabIndex = 5;
            this.betting.Text = " Bet";
            this.betting.UseVisualStyleBackColor = false;
            this.betting.Click += new System.EventHandler(this.Bets_Click);
            // 
            // VickyButton
            // 
            this.VickyButton.AutoSize = true;
            this.VickyButton.Checked = true;
            this.VickyButton.Location = new System.Drawing.Point(19, 119);
            this.VickyButton.Margin = new System.Windows.Forms.Padding(4);
            this.VickyButton.Name = "VickyButton";
            this.VickyButton.Size = new System.Drawing.Size(62, 21);
            this.VickyButton.TabIndex = 3;
            this.VickyButton.TabStop = true;
            this.VickyButton.Text = "Vicky";
            this.VickyButton.UseVisualStyleBackColor = true;
            this.VickyButton.CheckedChanged += new System.EventHandler(this.P3Button_CheckedChanged);
            // 
            // GouravButton
            // 
            this.GouravButton.AutoSize = true;
            this.GouravButton.Location = new System.Drawing.Point(19, 90);
            this.GouravButton.Margin = new System.Windows.Forms.Padding(4);
            this.GouravButton.Name = "GouravButton";
            this.GouravButton.Size = new System.Drawing.Size(76, 21);
            this.GouravButton.TabIndex = 2;
            this.GouravButton.Text = "Gourav";
            this.GouravButton.UseVisualStyleBackColor = true;
            this.GouravButton.CheckedChanged += new System.EventHandler(this.P2Button_CheckedChanged);
            // 
            // AviButton
            // 
            this.AviButton.AutoSize = true;
            this.AviButton.Location = new System.Drawing.Point(19, 60);
            this.AviButton.Margin = new System.Windows.Forms.Padding(4);
            this.AviButton.Name = "AviButton";
            this.AviButton.Size = new System.Drawing.Size(48, 21);
            this.AviButton.TabIndex = 1;
            this.AviButton.Text = "Avi";
            this.AviButton.UseVisualStyleBackColor = true;
            this.AviButton.CheckedChanged += new System.EventHandler(this.P1Button_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(453, 121);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // racer4
            // 
            this.racer4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racer4.Image = global::RaceGameAmrit.Resource1.red_car_v2;
            this.racer4.Location = new System.Drawing.Point(16, 192);
            this.racer4.Margin = new System.Windows.Forms.Padding(4);
            this.racer4.Name = "racer4";
            this.racer4.Size = new System.Drawing.Size(95, 58);
            this.racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer4.TabIndex = 25;
            this.racer4.TabStop = false;
            // 
            // racer3
            // 
            this.racer3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racer3.Image = global::RaceGameAmrit.Resource1.images;
            this.racer3.Location = new System.Drawing.Point(16, 129);
            this.racer3.Margin = new System.Windows.Forms.Padding(4);
            this.racer3.Name = "racer3";
            this.racer3.Size = new System.Drawing.Size(95, 55);
            this.racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer3.TabIndex = 24;
            this.racer3.TabStop = false;
            // 
            // racer2
            // 
            this.racer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racer2.Image = global::RaceGameAmrit.Resource1._1967_camaro;
            this.racer2.Location = new System.Drawing.Point(16, 69);
            this.racer2.Margin = new System.Windows.Forms.Padding(4);
            this.racer2.Name = "racer2";
            this.racer2.Size = new System.Drawing.Size(95, 52);
            this.racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer2.TabIndex = 23;
            this.racer2.TabStop = false;
            // 
            // racer1
            // 
            this.racer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racer1.Image = global::RaceGameAmrit.Resource1._15_jaguar_f_type_coupe_2020_fd_otr_front_0;
            this.racer1.Location = new System.Drawing.Point(16, 10);
            this.racer1.Margin = new System.Windows.Forms.Padding(4);
            this.racer1.Name = "racer1";
            this.racer1.Size = new System.Drawing.Size(95, 51);
            this.racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer1.TabIndex = 22;
            this.racer1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.Color.Transparent;
            this.racetrack.Image = global::RaceGameAmrit.Resource1.RACETRACK;
            this.racetrack.Location = new System.Drawing.Point(13, -40);
            this.racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(877, 290);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 21;
            this.racetrack.TabStop = false;
            this.racetrack.Click += new System.EventHandler(this.racetrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 554);
            this.Controls.Add(this.racer4);
            this.Controls.Add(this.racer3);
            this.Controls.Add(this.racer2);
            this.Controls.Add(this.racer1);
            this.Controls.Add(this.racetrack);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vickyBet;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label gouravBet;
        private System.Windows.Forms.Label aviBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown carNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Button betting;
        private System.Windows.Forms.RadioButton VickyButton;
        private System.Windows.Forms.RadioButton GouravButton;
        private System.Windows.Forms.RadioButton AviButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.PictureBox racer4;
        private System.Windows.Forms.PictureBox racer3;
        private System.Windows.Forms.PictureBox racer2;
        private System.Windows.Forms.PictureBox racer1;
        private System.Windows.Forms.PictureBox racetrack;
    }
}

