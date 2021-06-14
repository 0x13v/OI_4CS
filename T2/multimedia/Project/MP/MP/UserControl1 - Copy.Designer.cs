
using System;

namespace MP
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.Play_btn = new System.Windows.Forms.PictureBox();
            this.Next_btn = new System.Windows.Forms.PictureBox();
            this.Prev_btn = new System.Windows.Forms.PictureBox();
            this.list_btn = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.sound_btn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prev_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play_btn.Image = ((System.Drawing.Image)(resources.GetObject("Play_btn.Image")));
            this.Play_btn.Location = new System.Drawing.Point(65, 13);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(45, 39);
            this.Play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play_btn.TabIndex = 1;
            this.Play_btn.TabStop = false;
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Next_btn.Image = ((System.Drawing.Image)(resources.GetObject("Next_btn.Image")));
            this.Next_btn.Location = new System.Drawing.Point(116, 13);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(45, 39);
            this.Next_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next_btn.TabIndex = 2;
            this.Next_btn.TabStop = false;
            // 
            // Prev_btn
            // 
            this.Prev_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("Prev_btn.Image")));
            this.Prev_btn.Location = new System.Drawing.Point(14, 13);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(45, 39);
            this.Prev_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Prev_btn.TabIndex = 3;
            this.Prev_btn.TabStop = false;
            // 
            // list_btn
            // 
            this.list_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_btn.Image = ((System.Drawing.Image)(resources.GetObject("list_btn.Image")));
            this.list_btn.Location = new System.Drawing.Point(868, 3);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(56, 52);
            this.list_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.list_btn.TabIndex = 4;
            this.list_btn.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Location = new System.Drawing.Point(219, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(209, 27);
            this.trackBar1.TabIndex = 5;
            // 
            // sound_btn
            // 
            this.sound_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sound_btn.Image = ((System.Drawing.Image)(resources.GetObject("sound_btn.Image")));
            this.sound_btn.Location = new System.Drawing.Point(167, 13);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(45, 39);
            this.sound_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound_btn.TabIndex = 6;
            this.sound_btn.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += Play_btn_Click;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.list_btn);
            this.Controls.Add(this.Prev_btn);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Play_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(941, 59);
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prev_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Play_btn;
        private System.Windows.Forms.PictureBox Next_btn;
        private System.Windows.Forms.PictureBox Prev_btn;
        private System.Windows.Forms.PictureBox list_btn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox sound_btn;
        private System.Windows.Forms.Button button1;
    }
}
