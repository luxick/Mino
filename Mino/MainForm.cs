using Eto.Forms;
using Eto.Drawing;
using Mino.Commands;

namespace Mino
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Title = "Mino";
            ClientSize = new Size(800, 600);

            Content = new TableLayout
            (
                new MarkdownArea(this)
            );
            // create menu
            AddMenuBar();

            // create toolbar			
            ToolBar = new ToolBar {};
        }

        private void AddMenuBar()
        {
            var aboutItem = new ButtonMenuItem { Text = "About..." };
            aboutItem.Click += (sender, e) =>
            {
                var dlg = new Dialog
                { 
                    Content = new Label { Text = "About my app..." }, 
                    ClientSize = new Size(200, 200)
                };
                dlg.ShowModal(this);
            };
            
            Menu = new MenuBar
            {
                Items =
                {
                    new ButtonMenuItem
                    { 
                        Text = "&File",
                        Items =
                        {
                            new SyncCommand {MainWindow = this},
                        }
                    } 
                },
                ApplicationItems =
                {
                    // application (OS X) or file menu (others)
                    new ButtonMenuItem {Text = "&Preferences..."},
                },
                QuitItem = new Command((sender, e) => Application.Instance.Quit())
                { 
                    MenuText = "Quit", 
                    Shortcut = Application.Instance.CommonModifier | Keys.Q
                },
                AboutItem = aboutItem
            };
        }
    }
}