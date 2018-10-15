using System;
using Gtk;
using Hello.Library;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnShowHelloPressed(object sender, EventArgs e)
    {
        var dialog = new MessageDialog(
            this,
            DialogFlags.Modal,
            MessageType.Info,
            ButtonsType.Ok,
            HelloHelper.SayHello(txbInput.Text)
        );

        dialog.Run();
        dialog.Destroy();
    }
}
