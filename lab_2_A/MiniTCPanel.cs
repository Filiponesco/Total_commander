using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_2_A
{
    public partial class MiniTCPanel : UserControl, IViewMiniTCPanel
    {
        #region Prop
        public string CurrentPath
        {
            get {
                ///
                return textBox1.Text;
            }
            set {
                ////
                textBox1.Text = value;
                

            }
        }

        public string[] Drives {
            set
            {
                foreach (var d in value)
                {
                    comboBox1.Items.Add(d);
                }
            }
        }

        public string CurrentDisk
        {
            get
            {
                ///
                return comboBox1.SelectedItem.ToString();
            }
            set
            {
                ////
                comboBox1.SelectedText = value;

            }
        }
        public string SelectedFolder
        {
            get
            {
                return listBox1.SelectedItem.ToString();
            }
        }
        public string[] Contents
        {
            set
            {
                ////
                listBox1.Items.Clear();
                foreach (var s in value)
                {
                    listBox1.Items.Add(s);
                }


            }
        }

        public string SelectedFile
        {
            get
            {
                ////Warunek sprawdzajacy czy to plik, a nie folder
                return listBox1.SelectedItem.ToString();
            }
        }

        #endregion

        #region Events
        public event Action SelectDrive;
        public event Action PathChanged;
        public event Action PathBack;
        #endregion
        public MiniTCPanel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDrive();
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            PathChanged();
        }
        void IViewMiniTCPanel.Error(string e)
        {
            errorProvider1.SetError(textBox1, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PathBack();
        }
    }
}
