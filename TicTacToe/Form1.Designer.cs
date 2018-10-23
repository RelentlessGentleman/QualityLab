namespace TicTacToe
{
    partial class frmMain
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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btnMakeP1 = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnMakeP2 = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(85, 56);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(74, 70);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Visible = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(165, 56);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 70);
            this.btn10.TabIndex = 1;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Visible = false;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(246, 56);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 70);
            this.btn20.TabIndex = 2;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Visible = false;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(84, 132);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 70);
            this.btn01.TabIndex = 3;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Visible = false;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(165, 132);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 70);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Visible = false;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(246, 132);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 70);
            this.btn21.TabIndex = 5;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Visible = false;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(84, 208);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 70);
            this.btn02.TabIndex = 6;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Visible = false;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(165, 208);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 70);
            this.btn12.TabIndex = 7;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Visible = false;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(246, 208);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 70);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Visible = false;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btnMakeP1
            // 
            this.btnMakeP1.Location = new System.Drawing.Point(129, 184);
            this.btnMakeP1.Name = "btnMakeP1";
            this.btnMakeP1.Size = new System.Drawing.Size(72, 60);
            this.btnMakeP1.TabIndex = 9;
            this.btnMakeP1.Text = "Player1 Name Entry";
            this.btnMakeP1.UseVisualStyleBackColor = true;
            this.btnMakeP1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(139, 158);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(137, 20);
            this.txtPlayerName.TabIndex = 10;
            // 
            // btnMakeP2
            // 
            this.btnMakeP2.Location = new System.Drawing.Point(207, 184);
            this.btnMakeP2.Name = "btnMakeP2";
            this.btnMakeP2.Size = new System.Drawing.Size(73, 60);
            this.btnMakeP2.TabIndex = 11;
            this.btnMakeP2.Text = "Player2 Name Entry";
            this.btnMakeP2.UseVisualStyleBackColor = true;
            this.btnMakeP2.Click += new System.EventHandler(this.btnMakeP2_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(167, 27);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentPlayer.TabIndex = 12;
            this.lblCurrentPlayer.Text = "Current Player";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 351);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnMakeP2);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnMakeP1);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn00);
            this.Name = "frmMain";
            this.Text = "Tic Tac Toe Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btnMakeP1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnMakeP2;
        private System.Windows.Forms.Label lblCurrentPlayer;
    }
}

