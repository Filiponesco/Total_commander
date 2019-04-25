using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_A
{
    class Presenter
    {
        IView view;
        Model model;
        PresenterMiniTCPanel left;
        PresenterMiniTCPanel right;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.Copy += View_Copy;
            left = new PresenterMiniTCPanel(this.view.left, this.model);
            right = new PresenterMiniTCPanel(this.view.right, this.model);
        }
        private void View_Copy()
        {
            model.Model_Copy(view.left.SelectedFile, view.right.CurrentPath);
        }
    }
}
