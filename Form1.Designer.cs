
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
            this.LOAD_BTN = new System.Windows.Forms.Button();
            this.SPIN_BTN = new System.Windows.Forms.Button();
            this.SHOOTONHEAD_BTN = new System.Windows.Forms.Button();
            this.SHOOTAWAY_BTN = new System.Windows.Forms.Button();
            this.GAMEPROJECT = new System.Windows.Forms.LinkLabel();
            this.PLAY_BTN = new System.Windows.Forms.Button();
            this.EXIT_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LOAD_BTN
            // 
            this.LOAD_BTN.BackColor = System.Drawing.Color.Teal;
            this.LOAD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LOAD_BTN.Location = new System.Drawing.Point(12, 331);
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
            // SHOOTONHEAD_BTN
            // 
            this.SHOOTONHEAD_BTN.BackColor = System.Drawing.Color.Teal;
            this.SHOOTONHEAD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOOTONHEAD_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SHOOTONHEAD_BTN.Location = new System.Drawing.Point(326, 331);
            this.SHOOTONHEAD_BTN.Name = "SHOOTONHEAD_BTN";
            this.SHOOTONHEAD_BTN.Size = new System.Drawing.Size(205, 49);
            this.SHOOTONHEAD_BTN.TabIndex = 2;
            this.SHOOTONHEAD_BTN.Text = "SHOOT ON HEAD";
            this.SHOOTONHEAD_BTN.UseVisualStyleBackColor = false;
            // 
            // SHOOTAWAY_BTN
            // 
            this.SHOOTAWAY_BTN.BackColor = System.Drawing.Color.Teal;
            this.SHOOTAWAY_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOOTAWAY_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SHOOTAWAY_BTN.Location = new System.Drawing.Point(549, 331);
            this.SHOOTAWAY_BTN.Name = "SHOOTAWAY_BTN";
            this.SHOOTAWAY_BTN.Size = new System.Drawing.Size(175, 49);
            this.SHOOTAWAY_BTN.TabIndex = 3;
            this.SHOOTAWAY_BTN.Text = "SHOOT AWAY ";
            this.SHOOTAWAY_BTN.UseVisualStyleBackColor = false;
            // 
            // GAMEPROJECT
            // 
            this.GAMEPROJECT.AutoSize = true;
            this.GAMEPROJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GAMEPROJECT.LinkColor = System.Drawing.Color.White;
            this.GAMEPROJECT.Location = new System.Drawing.Point(259, 29);
            this.GAMEPROJECT.Name = "GAMEPROJECT";
            this.GAMEPROJECT.Size = new System.Drawing.Size(235, 31);
            this.GAMEPROJECT.TabIndex = 5;
            this.GAMEPROJECT.TabStop = true;
            this.GAMEPROJECT.Text = "GAME PROJECT ";
            // 
            // PLAY_BTN
            // 
            this.PLAY_BTN.BackColor = System.Drawing.Color.Teal;
            this.PLAY_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY_BTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PLAY_BTN.Location = new System.Drawing.Point(50, 138);
            this.PLAY_BTN.Name = "PLAY_BTN";
            this.PLAY_BTN.Size = new System.Drawing.Size(105, 41);
            this.PLAY_BTN.TabIndex = 6;
            this.PLAY_BTN.Text = "PLAY";
            this.PLAY_BTN.UseVisualStyleBackColor = false;
            this.PLAY_BTN.Click += new System.EventHandler(this.PLAY_BTN_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 179);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EXIT_BTN);
            this.Controls.Add(this.PLAY_BTN);
            this.Controls.Add(this.GAMEPROJECT);
            this.Controls.Add(this.SHOOTAWAY_BTN);
            this.Controls.Add(this.SHOOTONHEAD_BTN);
            this.Controls.Add(this.SPIN_BTN);
            this.Controls.Add(this.LOAD_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game_form";
            this.Text = "Game form";
            this.Load += new System.EventHandler(this.Game_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button SHOOTONHEAD_BTN;
        private System.Windows.Forms.Button SHOOTAWAY_BTN;
        private System.Windows.Forms.LinkLabel GAMEPROJECT;
        private System.Windows.Forms.Button PLAY_BTN;
        private System.Windows.Forms.Button EXIT_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;

        public EventHandler SHOOTONHEAD_BTN_Click { get; private set; }
    }
}

