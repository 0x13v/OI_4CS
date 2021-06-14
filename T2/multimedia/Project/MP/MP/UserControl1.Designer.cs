
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
            this.Volum = new System.Windows.Forms.TrackBar();
            this.FullScreen_btn = new System.Windows.Forms.PictureBox();
            this.sound_btn = new System.Windows.Forms.PictureBox();
            this.list_btn = new System.Windows.Forms.PictureBox();
            this.Prev_btn = new System.Windows.Forms.PictureBox();
            this.Next_btn = new System.Windows.Forms.PictureBox();
            this.Play_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Volum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prev_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Volum
            // 
            this.Volum.AutoSize = false;
            this.Volum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Volum.Location = new System.Drawing.Point(219, 19);
            this.Volum.Maximum = 100;
            this.Volum.Name = "Volum";
            this.Volum.Size = new System.Drawing.Size(209, 27);
            this.Volum.TabIndex = 5;
            this.Volum.Value = 50;
            // 
            // FullScreen_btn
            // 
            this.FullScreen_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FullScreen_btn.Image = global::MP.Properties.Resources.FullScreen;
            this.FullScreen_btn.Location = new System.Drawing.Point(806, 3);
            this.FullScreen_btn.Name = "FullScreen_btn";
            this.FullScreen_btn.Size = new System.Drawing.Size(56, 52);
            this.FullScreen_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullScreen_btn.TabIndex = 7;
            this.FullScreen_btn.TabStop = false;
            // 
            // sound_btn
            // 
            this.sound_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sound_btn.Image = global::MP.Properties.Resources.Sound;
            this.sound_btn.Location = new System.Drawing.Point(167, 13);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(45, 39);
            this.sound_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sound_btn.TabIndex = 6;
            this.sound_btn.TabStop = false;
            // 
            // list_btn
            // 
            this.list_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.list_btn.Image = global::MP.Properties.Resources.List;
            this.list_btn.Location = new System.Drawing.Point(868, 3);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(56, 52);
            this.list_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.list_btn.TabIndex = 4;
            this.list_btn.TabStop = false;
            // 
            // Prev_btn
            // 
            this.Prev_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prev_btn.Image = global::MP.Properties.Resources.Prev;
            this.Prev_btn.Location = new System.Drawing.Point(14, 13);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(45, 39);
            this.Prev_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Prev_btn.TabIndex = 3;
            this.Prev_btn.TabStop = false;
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Next_btn.Image = global::MP.Properties.Resources.Next;
            this.Next_btn.Location = new System.Drawing.Point(116, 13);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(45, 39);
            this.Next_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next_btn.TabIndex = 2;
            this.Next_btn.TabStop = false;
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play_btn.Image = global::MP.Properties.Resources.play;
            this.Play_btn.Location = new System.Drawing.Point(65, 13);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(45, 39);
            this.Play_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play_btn.TabIndex = 1;
            this.Play_btn.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.FullScreen_btn);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.Volum);
            this.Controls.Add(this.list_btn);
            this.Controls.Add(this.Prev_btn);
            this.Controls.Add(this.Next_btn);
            this.Controls.Add(this.Play_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(941, 59);
            ((System.ComponentModel.ISupportInitialize)(this.Volum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prev_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Next_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Play_btn;
        public System.Windows.Forms.PictureBox Next_btn;
        public System.Windows.Forms.PictureBox Prev_btn;
        public System.Windows.Forms.PictureBox list_btn;
        public System.Windows.Forms.TrackBar Volum;
        public System.Windows.Forms.PictureBox sound_btn;
        public System.Windows.Forms.PictureBox FullScreen_btn;
    }
}
