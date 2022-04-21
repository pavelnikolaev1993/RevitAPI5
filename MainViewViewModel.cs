using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Prism.Commands;
using RevitApiTraningLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPI5
{
    public class MainViewViewModel
    {
        private ExternalCommandData _commandData;

        public DelegateCommand PipeCommand { get; }
        public DelegateCommand WallCommand { get; }
        public DelegateCommand DoorCommand { get; }

        public MainViewViewModel(ExternalCommandData commandData)
        {
            _commandData = commandData;
            PipeCommand = new DelegateCommand(OnPipeCommand);
            WallCommand = new DelegateCommand(OnWallCommand);
            DoorCommand = new DelegateCommand(OnDoorCommand);
        }
        public event EventHandler HideRequest;
        private void RaiseHideRequest()
        {
            HideRequest?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ShowRequest;
        private void RaiseShowRequest()
        {
            ShowRequest?.Invoke(this, EventArgs.Empty);
        }

        private void OnPipeCommand()
        {
            RaiseHideRequest();


            Result oElement = SelectionUtils.Execute1(_commandData);

            

            RaiseShowRequest();
        }
        private void OnWallCommand()
        {
            RaiseHideRequest();


            Result oElement = SelectionUtils.Execute2(_commandData);



            RaiseShowRequest();
        }
        private void OnDoorCommand()
        {
            RaiseHideRequest();


            Result oElement = SelectionUtils.Execute3(_commandData);



            RaiseShowRequest();
        }


    }
}
