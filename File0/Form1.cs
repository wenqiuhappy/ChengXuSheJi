using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DriveInfo[] driveInfos= DriveInfo.GetDrives();
            foreach (var item in driveInfos)
            {
                
            }

            // 创建文件夹  或 获取文件夹信息
            DirectoryInfo directoryInfo = Directory.CreateDirectory("C:\\2019\\07\\26");
            string s= directoryInfo.FullName;

            FileStream fileStream = new FileStream("C:\\2019\\07\\26\\txt.config",FileMode.Append);           

            
        }
    }
}
