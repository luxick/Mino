using System;
using Eto.Forms;

namespace Mino.Commands
{
    public class SyncCommand : Command
    {
        public Window MainWindow { get; set; }
        public SyncCommand()
        {
            MenuText = "Sync";
            ToolBarText = "Sync";
            ToolTip = "Resync database with server";
            Shortcut = Application.Instance.CommonModifier | Application.Instance.AlternateModifier | Keys.S;
        }

        protected override void OnExecuted(EventArgs e)
        {
            base.OnExecuted(e);
            var dlg = new Dialog
            {
                Content = new Label {Text = "It Works"}
            };
            dlg.ShowModal(MainWindow);
        }
    }
}