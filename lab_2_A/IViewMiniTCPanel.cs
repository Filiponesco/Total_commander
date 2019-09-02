using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_A
{
    public interface IViewMiniTCPanel
    {
        string[] Drives { set; }

        string CurrentPath { get; set; }

        string CurrentDisk { get; set; }

        string SelectedFolder { get;}

        string SelectedFile { get; }

        string[] Contents { set; }

        void Error(string e);

        event Action SelectDrive;
        event Action PathChanged;
        event Action PathBack;
    }
}
