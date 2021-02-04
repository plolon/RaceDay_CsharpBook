
namespace raceday
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.janekRadioButton = new System.Windows.Forms.RadioButton();
            this.bartekRadioButton = new System.Windows.Forms.RadioButton();
            this.arekRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.moneyUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dogUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.janekBetLabel = new System.Windows.Forms.Label();
            this.bartekBetLabel = new System.Windows.Forms.Label();
            this.arekBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(18, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(480, 237);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(134, 92);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dom bukmacherski";
            // 
            // janekRadioButton
            // 
            this.janekRadioButton.AutoSize = true;
            this.janekRadioButton.Checked = true;
            this.janekRadioButton.Location = new System.Drawing.Point(12, 249);
            this.janekRadioButton.Name = "janekRadioButton";
            this.janekRadioButton.Size = new System.Drawing.Size(110, 17);
            this.janekRadioButton.TabIndex = 7;
            this.janekRadioButton.TabStop = true;
            this.janekRadioButton.Text = "janekRadioButton";
            this.janekRadioButton.UseVisualStyleBackColor = true;
            this.janekRadioButton.CheckedChanged += new System.EventHandler(this.janekRadioButton_CheckedChanged);
            // 
            // bartekRadioButton
            // 
            this.bartekRadioButton.AutoSize = true;
            this.bartekRadioButton.Location = new System.Drawing.Point(12, 272);
            this.bartekRadioButton.Name = "bartekRadioButton";
            this.bartekRadioButton.Size = new System.Drawing.Size(114, 17);
            this.bartekRadioButton.TabIndex = 8;
            this.bartekRadioButton.Text = "bartekRadioButton";
            this.bartekRadioButton.UseVisualStyleBackColor = true;
            this.bartekRadioButton.CheckedChanged += new System.EventHandler(this.bartekRadioButton_CheckedChanged);
            // 
            // arekRadioButton
            // 
            this.arekRadioButton.AutoSize = true;
            this.arekRadioButton.Location = new System.Drawing.Point(12, 295);
            this.arekRadioButton.Name = "arekRadioButton";
            this.arekRadioButton.Size = new System.Drawing.Size(105, 17);
            this.arekRadioButton.TabIndex = 9;
            this.arekRadioButton.Text = "arekRadioButton";
            this.arekRadioButton.UseVisualStyleBackColor = true;
            this.arekRadioButton.CheckedChanged += new System.EventHandler(this.arekRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(15, 233);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(113, 13);
            this.minimumBetLabel.TabIndex = 10;
            this.minimumBetLabel.Text = "Minimalny zakład: ";
            this.minimumBetLabel.Click += new System.EventHandler(this.minimumBetLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 339);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "nameLabel";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(81, 334);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(58, 23);
            this.betButton.TabIndex = 12;
            this.betButton.Text = "stawia";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // moneyUpDown
            // 
            this.moneyUpDown.Location = new System.Drawing.Point(145, 337);
            this.moneyUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.moneyUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.moneyUpDown.Name = "moneyUpDown";
            this.moneyUpDown.Size = new System.Drawing.Size(54, 20);
            this.moneyUpDown.TabIndex = 13;
            this.moneyUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.moneyUpDown.ValueChanged += new System.EventHandler(this.moneyUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "zł na charta numer";
            // 
            // dogUpDown
            // 
            this.dogUpDown.Location = new System.Drawing.Point(308, 336);
            this.dogUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogUpDown.Name = "dogUpDown";
            this.dogUpDown.Size = new System.Drawing.Size(32, 20);
            this.dogUpDown.TabIndex = 15;
            this.dogUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(163, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zakłady";
            // 
            // janekBetLabel
            // 
            this.janekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.janekBetLabel.Location = new System.Drawing.Point(166, 253);
            this.janekBetLabel.Name = "janekBetLabel";
            this.janekBetLabel.Size = new System.Drawing.Size(214, 13);
            this.janekBetLabel.TabIndex = 17;
            this.janekBetLabel.Text = "janekBetLabel";
            // 
            // bartekBetLabel
            // 
            this.bartekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bartekBetLabel.Location = new System.Drawing.Point(166, 276);
            this.bartekBetLabel.Name = "bartekBetLabel";
            this.bartekBetLabel.Size = new System.Drawing.Size(214, 13);
            this.bartekBetLabel.TabIndex = 18;
            this.bartekBetLabel.Text = "bartekBetLabel";
            // 
            // arekBetLabel
            // 
            this.arekBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arekBetLabel.Location = new System.Drawing.Point(166, 299);
            this.arekBetLabel.Name = "arekBetLabel";
            this.arekBetLabel.Size = new System.Drawing.Size(216, 13);
            this.arekBetLabel.TabIndex = 19;
            this.arekBetLabel.Text = "arekBetLabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 75;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 361);
            this.Controls.Add(this.arekBetLabel);
            this.Controls.Add(this.bartekBetLabel);
            this.Controls.Add(this.janekBetLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dogUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyUpDown);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.arekRadioButton);
            this.Controls.Add(this.bartekRadioButton);
            this.Controls.Add(this.janekRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = " Dzień na wyścigach";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton janekRadioButton;
        private System.Windows.Forms.RadioButton bartekRadioButton;
        private System.Windows.Forms.RadioButton arekRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown moneyUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dogUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label janekBetLabel;
        private System.Windows.Forms.Label bartekBetLabel;
        private System.Windows.Forms.Label arekBetLabel;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
    }
}

