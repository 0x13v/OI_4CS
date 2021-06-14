using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MP
{
    class MediaHandeller
    {
        public List<MediaHandeller> MediaList = new List<MediaHandeller>();
        public string File_Name { get; set; }
        public string File_Path { get; set; }
        private void Add_files(string[] files) {
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                MediaList.Add(new MediaHandeller() { File_Name = Path.GetFileNameWithoutExtension(info.FullName), File_Path = info.FullName });
            }
        }
        public void addMedia() {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Video Files(*.mp4)|*.mp4|Audio File(*.mp3)|*.mp3|All Files|*.*";
            FileDialog.Multiselect = true;
            FileDialog.ValidateNames = true;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Add_files(FileDialog.FileNames);
            }
        }
    }
}
