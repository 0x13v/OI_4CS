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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public EventHandler Play_btn_Click { get; set; }
        public event EventHandler Next_btn_Click;
        public event EventHandler Prev_btn_Click;
        public event EventHandler sound_btn_Click;
        public event EventHandler list_btn_Click;

        
    }
}
