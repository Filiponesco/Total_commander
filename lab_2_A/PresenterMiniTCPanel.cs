using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_A
{
    class PresenterMiniTCPanel
    {
        IViewMiniTCPanel viewTC;
        Model model;

        public PresenterMiniTCPanel(IViewMiniTCPanel viewTC, Model model)
        {
            this.viewTC = viewTC;
            this.model = model;
            this.viewTC.SelectDrive += Select_Drive;
            this.viewTC.PathChanged += Path_Changed;
        }
        private void Select_Drive()
        {
            viewTC.CurrentPath = viewTC.CurrentDisk;
            if (model.ShowFiles(viewTC.CurrentPath) != null)
                viewTC.Contents = model.ShowFiles(viewTC.CurrentPath);
        }
        private void Path_Changed()
        {
            viewTC.CurrentPath = viewTC.SelectedFolder;
            if(model.ShowFiles(viewTC.CurrentPath) != null)
                viewTC.Contents = model.ShowFiles(viewTC.CurrentPath);
        }
    }
}
