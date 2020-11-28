namespace POE
{
    partial class FrmGameView
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
            this.LblMap = new System.Windows.Forms.Label();
            this.LblPlayerStats = new System.Windows.Forms.Label();
            this.lblCombat = new System.Windows.Forms.Label();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.lblEnemyData = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMap
            // 
            this.LblMap.AutoSize = true;
            this.LblMap.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMap.Location = new System.Drawing.Point(49, 59);
            this.LblMap.Name = "LblMap";
            this.LblMap.Padding = new System.Windows.Forms.Padding(2);
            this.LblMap.Size = new System.Drawing.Size(4, 20);
            this.LblMap.TabIndex = 0;
            // 
            // LblPlayerStats
            // 
            this.LblPlayerStats.AutoSize = true;
            this.LblPlayerStats.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerStats.Location = new System.Drawing.Point(405, 59);
            this.LblPlayerStats.Name = "LblPlayerStats";
            this.LblPlayerStats.Size = new System.Drawing.Size(0, 16);
            this.LblPlayerStats.TabIndex = 1;
            // 
            // lblCombat
            // 
            this.lblCombat.AutoSize = true;
            this.lblCombat.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombat.Location = new System.Drawing.Point(400, 217);
            this.lblCombat.Name = "lblCombat";
            this.lblCombat.Size = new System.Drawing.Size(0, 16);
            this.lblCombat.TabIndex = 2;
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(523, 375);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAttackLeft.TabIndex = 3;
            this.btnAttackLeft.Text = "Attack Left";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.BtnAttackLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(596, 346);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(82, 23);
            this.btnAttackUp.TabIndex = 4;
            this.btnAttackUp.Text = "Attack Up";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.BtnAttackUp_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(677, 375);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(75, 23);
            this.btnAttackRight.TabIndex = 5;
            this.btnAttackRight.Text = "Attack Right";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.BtnAttackRight_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(596, 404);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(82, 23);
            this.btnAttackDown.TabIndex = 6;
            this.btnAttackDown.Text = "Attack Down";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.BtnAttackDown_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(117, 404);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(82, 23);
            this.btnMoveDown.TabIndex = 10;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(198, 375);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 9;
            this.btnMoveRight.Text = "Move Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(117, 346);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(82, 23);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(44, 375);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 7;
            this.btnMoveLeft.Text = "Move Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // lblEnemyData
            // 
            this.lblEnemyData.AutoSize = true;
            this.lblEnemyData.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyData.Location = new System.Drawing.Point(598, 33);
            this.lblEnemyData.Name = "lblEnemyData";
            this.lblEnemyData.Size = new System.Drawing.Size(0, 16);
            this.lblEnemyData.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(322, 404);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(403, 404);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblEnemyData);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.lblCombat);
            this.Controls.Add(this.LblPlayerStats);
            this.Controls.Add(this.LblMap);
            this.Name = "FrmGameView";
            this.Text = "Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMap;
        private System.Windows.Forms.Label LblPlayerStats;
        private System.Windows.Forms.Label lblCombat;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Label lblEnemyData;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

