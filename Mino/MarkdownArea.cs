using Eto.Forms;

namespace Mino
{
    public class MarkdownArea : TextArea
    {
        private readonly Window _owner;
        
        public MarkdownArea(Window owner)
        {
            _owner = owner;
            Style = "TextConsole";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            e.Handled = true;
            if (e.Alt && e.Key == Keys.Enter)
            {
                var dlg = new Dialog
                {
                    Content = new Label {Text = "Insert new Item of: ???"}
                };
                dlg.ShowModal(_owner);
            }
            else
            {
                e.Handled = false;
                base.OnKeyDown(e);
            }
        }

        // protected override void OnKeyUp(KeyEventArgs e)
        // {
        //     e.Handled = true;
        //     if (e.Alt && e.Key == Keys.Enter)
        //     {
        //         var dlg = new Dialog
        //         {
        //             Content = new Label {Text = "Insert new Item of: ???"}
        //         };
        //         dlg.ShowModal(_owner);
        //     }
        //     else
        //     {
        //         e.Handled = false;
        //         base.OnKeyUp(e);
        //     }
        // }
    }
}