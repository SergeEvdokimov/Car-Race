namespace Car_Race
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.pbBondRight = new System.Windows.Forms.PictureBox();
            this.pbBondLeft = new System.Windows.Forms.PictureBox();
            this.pbRoadLine1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbRoadLine3 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine2 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBondRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBondLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).BeginInit();
            this.SuspendLayout();
            // 
            // Coin4
            // 
            this.Coin4.Image = global::Car_Race.Properties.Resources.coin;
            this.Coin4.Location = new System.Drawing.Point(309, 201);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(35, 35);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin4.TabIndex = 2;
            this.Coin4.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(118, 239);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(251, 39);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Игра окончена";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCoins.Location = new System.Drawing.Point(25, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(87, 20);
            this.lblCoins.TabIndex = 5;
            this.lblCoins.Text = "Монет : 0";
            // 
            // Car
            // 
            this.Car.Image = global::Car_Race.Properties.Resources.car;
            this.Car.Location = new System.Drawing.Point(319, 339);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(50, 64);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 6;
            this.Car.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.Image = global::Car_Race.Properties.Resources.police;
            this.Enemy1.Location = new System.Drawing.Point(420, 130);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(40, 55);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 7;
            this.Enemy1.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.Image = global::Car_Race.Properties.Resources.police;
            this.Enemy2.Location = new System.Drawing.Point(123, 51);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(40, 55);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 8;
            this.Enemy2.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.Image = global::Car_Race.Properties.Resources.police;
            this.Enemy3.Location = new System.Drawing.Point(29, 323);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(40, 55);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 9;
            this.Enemy3.TabStop = false;
            // 
            // pbBondRight
            // 
            this.pbBondRight.BackColor = System.Drawing.Color.White;
            this.pbBondRight.Location = new System.Drawing.Point(476, 0);
            this.pbBondRight.Name = "pbBondRight";
            this.pbBondRight.Size = new System.Drawing.Size(20, 450);
            this.pbBondRight.TabIndex = 10;
            this.pbBondRight.TabStop = false;
            // 
            // pbBondLeft
            // 
            this.pbBondLeft.BackColor = System.Drawing.Color.White;
            this.pbBondLeft.Location = new System.Drawing.Point(5, 0);
            this.pbBondLeft.Name = "pbBondLeft";
            this.pbBondLeft.Size = new System.Drawing.Size(20, 450);
            this.pbBondLeft.TabIndex = 11;
            this.pbBondLeft.TabStop = false;
            // 
            // pbRoadLine1
            // 
            this.pbRoadLine1.BackColor = System.Drawing.Color.White;
            this.pbRoadLine1.Location = new System.Drawing.Point(247, 113);
            this.pbRoadLine1.Name = "pbRoadLine1";
            this.pbRoadLine1.Size = new System.Drawing.Size(20, 100);
            this.pbRoadLine1.TabIndex = 12;
            this.pbRoadLine1.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = global::Car_Race.Properties.Resources.coin;
            this.Coin2.Location = new System.Drawing.Point(125, 150);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(35, 35);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 16;
            this.Coin2.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = global::Car_Race.Properties.Resources.coin;
            this.Coin1.Location = new System.Drawing.Point(53, 243);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(35, 35);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 17;
            this.Coin1.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = global::Car_Race.Properties.Resources.coin;
            this.Coin3.Location = new System.Drawing.Point(361, 45);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(35, 35);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 18;
            this.Coin3.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pbRoadLine3
            // 
            this.pbRoadLine3.BackColor = System.Drawing.Color.White;
            this.pbRoadLine3.Location = new System.Drawing.Point(247, 258);
            this.pbRoadLine3.Name = "pbRoadLine3";
            this.pbRoadLine3.Size = new System.Drawing.Size(20, 100);
            this.pbRoadLine3.TabIndex = 19;
            this.pbRoadLine3.TabStop = false;
            // 
            // pbRoadLine2
            // 
            this.pbRoadLine2.BackColor = System.Drawing.Color.White;
            this.pbRoadLine2.Location = new System.Drawing.Point(247, -45);
            this.pbRoadLine2.Name = "pbRoadLine2";
            this.pbRoadLine2.Size = new System.Drawing.Size(20, 100);
            this.pbRoadLine2.TabIndex = 20;
            this.pbRoadLine2.TabStop = false;
            // 
            // pbRoadLine4
            // 
            this.pbRoadLine4.BackColor = System.Drawing.Color.White;
            this.pbRoadLine4.Location = new System.Drawing.Point(247, 397);
            this.pbRoadLine4.Name = "pbRoadLine4";
            this.pbRoadLine4.Size = new System.Drawing.Size(20, 100);
            this.pbRoadLine4.TabIndex = 21;
            this.pbRoadLine4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.pbRoadLine4);
            this.Controls.Add(this.pbRoadLine2);
            this.Controls.Add(this.pbRoadLine3);
            this.Controls.Add(this.pbRoadLine1);
            this.Controls.Add(this.pbBondLeft);
            this.Controls.Add(this.pbBondRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBondRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBondLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox pbBondRight;
        private System.Windows.Forms.PictureBox pbBondLeft;
        private System.Windows.Forms.PictureBox pbRoadLine1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbRoadLine3;
        private System.Windows.Forms.PictureBox pbRoadLine2;
        private System.Windows.Forms.PictureBox pbRoadLine4;
    }
}

