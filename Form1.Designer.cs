
using System;

namespace GameProject
{
    partial class Game_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_form));
            this.LOAD_BTN = new System.Windows.Forms.Button();
            this.SPIN_BTN = new System.Windows.Forms.Button();
            this.BTN_SHOOT = new System.Windows.Forms.Button();
            this.SHOOTAWAY_BTN = new System.Windows.Forms.Button();
            this.GAMEPROJECT = new System.Windows.Forms.LinkLabel();
            this.BTN_PLAYAGAIN = new System.Windows.Forms.Button();
            this.EXIT_BTN = new System.Windows.Forms.Button();
            this.picbox_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // LOAD_BTN
            // 
            this.LOAD_BTN.BackColor = System.Drawing.Color.Teal;
            this.LOAD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LOAD_BTN.Location = new System.Drawing.Point(12, 249);
            this.LOAD_BTN.Name = "LOAD_BTN";
            this.LOAD_BTN.Size = new System.Drawing.Size(143, 49);
            this.LOAD_BTN.TabIndex = 0;
            this.LOAD_BTN.Text = "LOAD";
            this.LOAD_BTN.UseVisualStyleBackColor = false;
            this.LOAD_BTN.Click += new System.EventHandler(this.LOAD_BTN_Click);
            // 
            // SPIN_BTN
            // 
            this.SPIN_BTN.BackColor = System.Drawing.Color.Teal;
            this.SPIN_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPIN_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SPIN_BTN.Location = new System.Drawing.Point(172, 331);
            this.SPIN_BTN.Name = "SPIN_BTN";
            this.SPIN_BTN.Size = new System.Drawing.Size(131, 49);
            this.SPIN_BTN.TabIndex = 1;
            this.SPIN_BTN.Text = "SPIN";
            this.SPIN_BTN.UseVisualStyleBackColor = false;
            this.SPIN_BTN.Click += new System.EventHandler(this.SPIN_BTN_Click);
            // 
            // BTN_SHOOT
            // 
            this.BTN_SHOOT.BackColor = System.Drawing.Color.Teal;
            this.BTN_SHOOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SHOOT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_SHOOT.Location = new System.Drawing.Point(326, 331);
            this.BTN_SHOOT.Name = "BTN_SHOOT";
            this.BTN_SHOOT.Size = new System.Drawing.Size(205, 49);
            this.BTN_SHOOT.TabIndex = 2;
            this.BTN_SHOOT.Text = "SHOOT ON HEAD";
            this.BTN_SHOOT.UseVisualStyleBackColor = false;
            this.BTN_SHOOT.Click += new System.EventHandler(this.BTN_SHOOT_Click);
            // 
            // SHOOTAWAY_BTN
            // 
            this.SHOOTAWAY_BTN.BackColor = System.Drawing.Color.Teal;
            this.SHOOTAWAY_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOOTAWAY_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SHOOTAWAY_BTN.Location = new System.Drawing.Point(563, 249);
            this.SHOOTAWAY_BTN.Name = "SHOOTAWAY_BTN";
            this.SHOOTAWAY_BTN.Size = new System.Drawing.Size(175, 49);
            this.SHOOTAWAY_BTN.TabIndex = 3;
            this.SHOOTAWAY_BTN.Text = "SHOOT AWAY ";
            this.SHOOTAWAY_BTN.UseVisualStyleBackColor = false;
            this.SHOOTAWAY_BTN.Click += new System.EventHandler(this.SHOOTAWAY_BTN_Click);
            // 
            // GAMEPROJECT
            // 
            this.GAMEPROJECT.AutoSize = true;
            this.GAMEPROJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAMEPROJECT.LinkColor = System.Drawing.Color.White;
            this.GAMEPROJECT.Location = new System.Drawing.Point(254, 9);
            this.GAMEPROJECT.Name = "GAMEPROJECT";
            this.GAMEPROJECT.Size = new System.Drawing.Size(235, 31);
            this.GAMEPROJECT.TabIndex = 5;
            this.GAMEPROJECT.TabStop = true;
            this.GAMEPROJECT.Text = "GAME PROJECT ";
            // 
            // BTN_PLAYAGAIN
            // 
            this.BTN_PLAYAGAIN.BackColor = System.Drawing.Color.Teal;
            this.BTN_PLAYAGAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PLAYAGAIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_PLAYAGAIN.Location = new System.Drawing.Point(12, 138);
            this.BTN_PLAYAGAIN.Name = "BTN_PLAYAGAIN";
            this.BTN_PLAYAGAIN.Size = new System.Drawing.Size(127, 70);
            this.BTN_PLAYAGAIN.TabIndex = 6;
            this.BTN_PLAYAGAIN.Text = "PLAY AGAIN";
            this.BTN_PLAYAGAIN.UseVisualStyleBackColor = false;
            this.BTN_PLAYAGAIN.Click += new System.EventHandler(this.PLAY_BTN_Click);
            // 
            // EXIT_BTN
            // 
            this.EXIT_BTN.BackColor = System.Drawing.Color.Teal;
            this.EXIT_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EXIT_BTN.Location = new System.Drawing.Point(600, 138);
            this.EXIT_BTN.Name = "EXIT_BTN";
            this.EXIT_BTN.Size = new System.Drawing.Size(95, 41);
            this.EXIT_BTN.TabIndex = 7;
            this.EXIT_BTN.Text = " EXIT";
            this.EXIT_BTN.UseVisualStyleBackColor = false;
            this.EXIT_BTN.Click += new System.EventHandler(this.EXIT_BTN_Click);
            // 
            // picbox_main
            // 
            this.picbox_main.Image = ((System.Drawing.Image)(resources.GetObject("picbox_main.Image")));
            this.picbox_main.Location = new System.Drawing.Point(161, 63);
            this.picbox_main.Name = "picbox_main";
            this.picbox_main.Size = new System.Drawing.Size(396, 246);
            this.picbox_main.TabIndex = 8;
            this.picbox_main.TabStop = false;
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.picbox_main);
            this.Controls.Add(this.EXIT_BTN);
            this.Controls.Add(this.BTN_PLAYAGAIN);
            this.Controls.Add(this.GAMEPROJECT);
            this.Controls.Add(this.SHOOTAWAY_BTN);
            this.Controls.Add(this.BTN_SHOOT);
            this.Controls.Add(this.SPIN_BTN);
            this.Controls.Add(this.LOAD_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game_form";
            this.Text = "Game form";
            this.Load += new System.EventHandler(this.Game_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button LOAD_BTN;
        private System.Windows.Forms.Button SPIN_BTN;
        private System.Windows.Forms.Button BTN_SHOOT;
        private System.Windows.Forms.Button SHOOTAWAY_BTN;
        private System.Windows.Forms.LinkLabel GAMEPROJECT;
        private System.Windows.Forms.Button BTN_PLAYAGAIN;
        private System.Windows.Forms.Button EXIT_BTN;
        private System.Windows.Forms.PictureBox picbox_main;

        public EventHandler SHOOTONHEAD_BTN_Click { get; private set; }
    }
}

