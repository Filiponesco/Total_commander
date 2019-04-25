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

namespace lab_2_A
{
    public partial class Form1 : Form, IView
    {
        //private MiniTCPanel miniTCPanel; utworzone automatycznie w drugiej czesci klasy
        public Form1()
        {
            InitializeComponent();
            left = miniTCPanel1;
            left.Drives = Directory.GetLogicalDrives();

            right = miniTCPanel2;
            right.Drives = Directory.GetLogicalDrives();
        }

        public IViewMiniTCPanel left { get; set ; }
        public IViewMiniTCPanel right { get; set; }

        public event Action Copy;

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
            MessageBox.Show("Skopiowano");
        }
    }
}
