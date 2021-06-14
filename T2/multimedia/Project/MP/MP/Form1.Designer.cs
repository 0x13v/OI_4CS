
namespace MP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.userControl11 = new MP.UserControl1();
            this.listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-2, 2);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(941, 428);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControl11.Location = new System.Drawing.Point(-2, 398);
            this.userControl11.Margin = new System.Windows.Forms.Padding(2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(941, 61);
            this.userControl11.TabIndex = 1;
            // 
            // listbox
            // 
            this.listbox.Location = new System.Drawing.Point(763, 2);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(173, 381);
            this.listbox.TabIndex = 2;
            this.listbox.Visible = false;
            this.listbox.SelectedValueChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            this.listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(936, 457);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private UserControl1 userControl11;
        private System.Windows.Forms.ListBox listbox;
    }
}