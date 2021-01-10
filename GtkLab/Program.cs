using GtkDemo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace GtkLab
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Gtk.Application.Init();
            //Forms.Init();

            //var app = new App();
            //var window = new FormsWindow();
            //window.LoadApplication(app);
            //window.SetApplicationTitle("lindexi");
            //window.Show();
            //Gtk.Application.Run();

            Gtk.Application.Init();

            var app = new Gtk.Application("org.gtkapp.gtkapp", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new FormsWindow();
            //app.AddWindow(FormsWindow.MainWindow);

            //win.Show();
            Gtk.Application.Run();
        }
    }
}
