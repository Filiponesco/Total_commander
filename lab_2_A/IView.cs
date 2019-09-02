using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_A
{
    interface IView
    {
        IViewMiniTCPanel left { get; set; }
        IViewMiniTCPanel right{ get; set; }
        void Message(string s);

        event Action Copy;
    }
}
