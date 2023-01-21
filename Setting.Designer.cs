
namespace Snake_And_Ladder
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.chkAI = new System.Windows.Forms.CheckBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImage = global::Snake_And_Ladder.Properties.Resources.Blured;
            resources.ApplyResources(this.btnQuit, "btnQuit");
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPlay.BackgroundImage = global::Snake_And_Ladder.Properties.Resources.Blured;
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // chkAI
            // 
            resources.ApplyResources(this.chkAI, "chkAI");
            this.chkAI.BackColor = System.Drawing.Color.Transparent;
            this.chkAI.FlatAppearance.BorderSize = 0;
            this.chkAI.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.chkAI.Name = "chkAI";
            this.chkAI.UseVisualStyleBackColor = false;
            this.chkAI.CheckedChanged += new System.EventHandler(this.chkAI_CheckedChanged);
            // 
            // lblPlayer1
            // 
            resources.ApplyResources(this.lblPlayer1, "lblPlayer1");
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayer1.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPlayer1.Name = "lblPlayer1";
            // 
            // txtPlayer1
            // 
            resources.ApplyResources(this.txtPlayer1, "txtPlayer1");
            this.txtPlayer1.Name = "txtPlayer1";
            // 
            // txtPlayer2
            // 
            resources.ApplyResources(this.txtPlayer2, "txtPlayer2");
            this.txtPlayer2.Name = "txtPlayer2";
            // 
            // lblPlayer2
            // 
            resources.ApplyResources(this.lblPlayer2, "lblPlayer2");
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPlayer2.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPlayer2.Name = "lblPlayer2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Name = "label1";
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Snake_And_Ladder.Properties.Resources.snake_ladder;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.chkAI);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox chkAI;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label label1;
    }
}

