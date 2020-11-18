namespace gyak08_NKJBXO
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.btnRibbonColor = new System.Windows.Forms.Button();
            this.btnBoxColor = new System.Windows.Forms.Button();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.btnSelectPresent);
            this.mainPanel.Controls.Add(this.btnRibbonColor);
            this.mainPanel.Controls.Add(this.btnBoxColor);
            this.mainPanel.Controls.Add(this.btnBallColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnSelectBall);
            this.mainPanel.Controls.Add(this.btnSelectCar);
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(756, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectPresent.Location = new System.Drawing.Point(199, 13);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(88, 47);
            this.btnSelectPresent.TabIndex = 3;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.btnSelectPresent_Click);
            // 
            // btnRibbonColor
            // 
            this.btnRibbonColor.BackColor = System.Drawing.Color.Yellow;
            this.btnRibbonColor.Location = new System.Drawing.Point(199, 95);
            this.btnRibbonColor.Name = "btnRibbonColor";
            this.btnRibbonColor.Size = new System.Drawing.Size(88, 23);
            this.btnRibbonColor.TabIndex = 2;
            this.btnRibbonColor.UseVisualStyleBackColor = false;
            this.btnRibbonColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnBoxColor
            // 
            this.btnBoxColor.BackColor = System.Drawing.Color.Red;
            this.btnBoxColor.Location = new System.Drawing.Point(199, 66);
            this.btnBoxColor.Name = "btnBoxColor";
            this.btnBoxColor.Size = new System.Drawing.Size(88, 23);
            this.btnBoxColor.TabIndex = 2;
            this.btnBoxColor.UseVisualStyleBackColor = false;
            this.btnBoxColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnBallColor
            // 
            this.btnBallColor.BackColor = System.Drawing.Color.Blue;
            this.btnBallColor.Location = new System.Drawing.Point(105, 66);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(88, 23);
            this.btnBallColor.TabIndex = 2;
            this.btnBallColor.UseVisualStyleBackColor = false;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNext.Location = new System.Drawing.Point(341, 12);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Coming next:";
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectBall.Location = new System.Drawing.Point(105, 11);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(88, 48);
            this.btnSelectBall.TabIndex = 0;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.btnSelectBall_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectCar.Location = new System.Drawing.Point(11, 11);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(88, 48);
            this.btnSelectCar.TabIndex = 0;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gyak08_NKJBXO.Properties.Resources.sleigh3;
            this.pictureBox1.Location = new System.Drawing.Point(757, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 282);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnRibbonColor;
        private System.Windows.Forms.Button btnBoxColor;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

