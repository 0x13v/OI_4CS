using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP
{
    public partial class Form1 : Form
    {
        bool on = false;

        public Form1()
        {

            InitializeComponent();
            userControl11.Play_btn.Click += new EventHandler(Play_btn_Click);
            userControl11.Next_btn.Click += new EventHandler(Next_btn_Click);
            userControl11.Prev_btn.Click += new EventHandler(Prev_btnClick);
            userControl11.sound_btn.Click += new EventHandler(sound_btn_Click);
            userControl11.list_btn.Click += new EventHandler(list_btn_Click);
            userControl11.Volum.ValueChanged += new EventHandler(valueChanged);
            userControl11.FullScreen_btn.Click+= new EventHandler(FullScreen_btn_Click);
        }

        private void FullScreen_btn_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count > 0) {

                axWindowsMediaPlayer1.fullScreen = !(axWindowsMediaPlayer1.fullScreen);
            
            }
            
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if (userControl11.Volum.Value == 0)
            {
                sound_btn_Click(null, null);
            }
            else {
                axWindowsMediaPlayer1.settings.volume = userControl11.Volum.Value;
                userControl11.sound_btn.Image = MP.Properties.Resources.Sound;
               
            }

        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            listbox.Visible = !listbox.Visible;

        }

        private void sound_btn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute= !(axWindowsMediaPlayer1.settings.mute);
            if (axWindowsMediaPlayer1.settings.mute == true)
            {
                userControl11.sound_btn.Image = MP.Properties.Resources.Sound_M;
            }
            else
            {
                userControl11.sound_btn.Image = MP.Properties.Resources.Sound;
            }
            
        }

        private void Prev_btnClick(object sender, EventArgs e)
        {
            
            if (listbox.SelectedIndex - 1 >= 0)
            {
                listbox.SelectedIndex--;
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex + 1 < listbox.Items.Count) {
                listbox.SelectedIndex++;
            } 
        }


        private void Play_btn_Click(object sender, EventArgs e)
        {
            if(on)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                userControl11.Play_btn.Image = MP.Properties.Resources.play;
            }else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                userControl11.Play_btn.Image = MP.Properties.Resources.pause;
            }

            on = !on;
        }

        private void listbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog() { ValidateNames = true, Multiselect = true, Filter = "Video Files(*.mp4)|*.mp4|Audio File(*.mp3)|*.mp3|All Files|*.*" };
            if (FileDialog.ShowDialog() == DialogResult.OK) listbox.Items.AddRange(FileDialog.FileNames);
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listbox.SelectedItem as string;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            userControl11.Play_btn.Image = MP.Properties.Resources.pause;
            on = true;


        }
    }
}
