namespace ClickerGame
{
    partial class form1
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
            this.currencyDisplay = new System.Windows.Forms.Label();
            this.clickingObject = new System.Windows.Forms.Button();
            this.rewardLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.reward3 = new System.Windows.Forms.Label();
            this.reward2 = new System.Windows.Forms.Label();
            this.reward1 = new System.Windows.Forms.Label();
            this.upgrade3 = new System.Windows.Forms.Button();
            this.upgrade2 = new System.Windows.Forms.Button();
            this.upgrade1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.station1 = new System.Windows.Forms.Button();
            this.station2 = new System.Windows.Forms.Button();
            this.station3 = new System.Windows.Forms.Button();
            this.station4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addcap1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyDisplay
            // 
            this.currencyDisplay.AutoSize = true;
            this.currencyDisplay.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyDisplay.Location = new System.Drawing.Point(22, 44);
            this.currencyDisplay.Name = "currencyDisplay";
            this.currencyDisplay.Size = new System.Drawing.Size(119, 13);
            this.currencyDisplay.TabIndex = 3;
            this.currencyDisplay.Text = "Favour Details";
            // 
            // clickingObject
            // 
            this.clickingObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clickingObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickingObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickingObject.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickingObject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clickingObject.ImageKey = "(none)";
            this.clickingObject.Location = new System.Drawing.Point(25, 108);
            this.clickingObject.Name = "clickingObject";
            this.clickingObject.Size = new System.Drawing.Size(151, 124);
            this.clickingObject.TabIndex = 0;
            this.clickingObject.Text = "Perform Ritual";
            this.clickingObject.UseVisualStyleBackColor = true;
            this.clickingObject.Click += new System.EventHandler(this.ritualBox_Click);
            // 
            // rewardLabel
            // 
            this.rewardLabel.AutoSize = true;
            this.rewardLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rewardLabel.Location = new System.Drawing.Point(3, 0);
            this.rewardLabel.Name = "rewardLabel";
            this.rewardLabel.Size = new System.Drawing.Size(113, 12);
            this.rewardLabel.TabIndex = 5;
            this.rewardLabel.Text = "Sacrificial Boons:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.reward3);
            this.panel1.Controls.Add(this.reward2);
            this.panel1.Controls.Add(this.reward1);
            this.panel1.Controls.Add(this.rewardLabel);
            this.panel1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(234, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 157);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "[40 +] sacrifices:  \r\nbetter Shogoths";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reward3
            // 
            this.reward3.AutoSize = true;
            this.reward3.Location = new System.Drawing.Point(3, 48);
            this.reward3.Name = "reward3";
            this.reward3.Size = new System.Drawing.Size(119, 24);
            this.reward3.TabIndex = 8;
            this.reward3.Text = "[25 +} sacrifices: \r\n+100 per ritual\r\n";
            // 
            // reward2
            // 
            this.reward2.AutoSize = true;
            this.reward2.Location = new System.Drawing.Point(128, 17);
            this.reward2.Name = "reward2";
            this.reward2.Size = new System.Drawing.Size(119, 24);
            this.reward2.TabIndex = 7;
            this.reward2.Text = "[15 +} sacrifices: \r\nbetter cultists\r\n";
            this.reward2.Click += new System.EventHandler(this.reward2_Click);
            // 
            // reward1
            // 
            this.reward1.AutoSize = true;
            this.reward1.Location = new System.Drawing.Point(3, 17);
            this.reward1.Name = "reward1";
            this.reward1.Size = new System.Drawing.Size(119, 24);
            this.reward1.TabIndex = 6;
            this.reward1.Text = "[10 +] sacrifices: \r\n+20 per ritual";
            // 
            // upgrade3
            // 
            this.upgrade3.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade3.Image = global::ClickerGame.Properties.Resources.ancient_zyme;
            this.upgrade3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upgrade3.Location = new System.Drawing.Point(509, 104);
            this.upgrade3.Name = "upgrade3";
            this.upgrade3.Size = new System.Drawing.Size(230, 54);
            this.upgrade3.TabIndex = 7;
            this.upgrade3.Text = "Summon Shogoth:";
            this.upgrade3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.upgrade3.UseVisualStyleBackColor = true;
            this.upgrade3.Click += new System.EventHandler(this.upgrade3_Click);
            // 
            // upgrade2
            // 
            this.upgrade2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade2.Image = global::ClickerGame.Properties.Resources.blood_puddle_red;
            this.upgrade2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upgrade2.Location = new System.Drawing.Point(234, 44);
            this.upgrade2.Name = "upgrade2";
            this.upgrade2.Size = new System.Drawing.Size(269, 54);
            this.upgrade2.TabIndex = 4;
            this.upgrade2.Text = "Sacrifice Cultist:";
            this.upgrade2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.upgrade2.UseVisualStyleBackColor = true;
            this.upgrade2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // upgrade1
            // 
            this.upgrade1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade1.Image = global::ClickerGame.Properties.Resources.wizard;
            this.upgrade1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upgrade1.Location = new System.Drawing.Point(509, 44);
            this.upgrade1.Name = "upgrade1";
            this.upgrade1.Size = new System.Drawing.Size(230, 54);
            this.upgrade1.TabIndex = 2;
            this.upgrade1.Text = "Enlist Cultist: ";
            this.upgrade1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.upgrade1.UseVisualStyleBackColor = true;
            this.upgrade1.Click += new System.EventHandler(this.upgradeOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cultist Workstations:\r\n";
            // 
            // station1
            // 
            this.station1.Location = new System.Drawing.Point(509, 189);
            this.station1.Name = "station1";
            this.station1.Size = new System.Drawing.Size(230, 51);
            this.station1.TabIndex = 9;
            this.station1.Text = "Ritual Altar";
            this.station1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.station1.UseVisualStyleBackColor = true;
            // 
            // station2
            // 
            this.station2.Location = new System.Drawing.Point(509, 246);
            this.station2.Name = "station2";
            this.station2.Size = new System.Drawing.Size(230, 54);
            this.station2.TabIndex = 10;
            this.station2.Text = "button1";
            this.station2.UseVisualStyleBackColor = true;
            // 
            // station3
            // 
            this.station3.Location = new System.Drawing.Point(509, 306);
            this.station3.Name = "station3";
            this.station3.Size = new System.Drawing.Size(230, 54);
            this.station3.TabIndex = 11;
            this.station3.Text = "button2";
            this.station3.UseVisualStyleBackColor = true;
            // 
            // station4
            // 
            this.station4.Location = new System.Drawing.Point(509, 366);
            this.station4.Name = "station4";
            this.station4.Size = new System.Drawing.Size(230, 54);
            this.station4.TabIndex = 12;
            this.station4.Text = "button3";
            this.station4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addcap1
            // 
            this.addcap1.Location = new System.Drawing.Point(603, 217);
            this.addcap1.Name = "addcap1";
            this.addcap1.Size = new System.Drawing.Size(136, 23);
            this.addcap1.TabIndex = 16;
            this.addcap1.Text = "Buy";
            this.addcap1.UseVisualStyleBackColor = true;
            this.addcap1.Click += new System.EventHandler(this.addcap1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.addcap1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.station4);
            this.Controls.Add(this.station3);
            this.Controls.Add(this.station2);
            this.Controls.Add(this.station1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upgrade3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upgrade2);
            this.Controls.Add(this.currencyDisplay);
            this.Controls.Add(this.upgrade1);
            this.Controls.Add(this.clickingObject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "form1";
            this.Text = "Lovecraft Clicker";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickingObject;
        private System.Windows.Forms.Button upgrade1;
        private System.Windows.Forms.Label currencyDisplay;
        private System.Windows.Forms.Button upgrade2;
        private System.Windows.Forms.Label rewardLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reward1;
        private System.Windows.Forms.Label reward2;
        private System.Windows.Forms.Button upgrade3;
        private System.Windows.Forms.Label reward3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button station1;
        private System.Windows.Forms.Button station2;
        private System.Windows.Forms.Button station3;
        private System.Windows.Forms.Button station4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addcap1;
    }
}

