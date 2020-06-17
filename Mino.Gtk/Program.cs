using System;
using Eto;
using Eto.Drawing;
using Eto.Forms;
using Eto.GtkSharp.Forms.Controls;

namespace Mino.Gtk
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Eto.Platforms.Gtk).Run(new MainForm());
        }
    }
}