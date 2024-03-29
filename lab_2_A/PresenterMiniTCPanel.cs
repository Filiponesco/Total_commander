﻿using System;
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
            this.viewTC.PathBack += Path_Back;
        }
        private void Select_Drive()
        {
            viewTC.CurrentPath = viewTC.CurrentDisk;
            if (model.ShowFiles(viewTC.CurrentPath) != null)
                viewTC.Contents = model.ShowFiles(viewTC.CurrentPath);
        }
        private void Path_Changed()
        {
            try
            {
                viewTC.CurrentPath = viewTC.SelectedFolder;
                if (model.ShowFiles(viewTC.CurrentPath) != null)
                    viewTC.Contents = model.ShowFiles(viewTC.CurrentPath);
            }
            catch(Exception e)
            {
                viewTC.Error(e.Message);
            }
        }
        private void Path_Back()
        {
            try
            {      
                if (model.ShowFiles(viewTC.CurrentPath) != null)
                {
                    viewTC.CurrentPath = model.Model_Back(viewTC.CurrentPath);
                    viewTC.Contents = model.ShowFiles(viewTC.CurrentPath);
                }

            }
            catch(Exception e)
            {
                viewTC.Error(e.Message);
            }
        }
    }
}
