
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed @fixed;

	private global::Gtk.Entry txbInput;

	private global::Gtk.Button btnShowHello;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.WidthRequest = 332;
		this.HeightRequest = 100;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Hello");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.@fixed = new global::Gtk.Fixed();
		this.@fixed.WidthRequest = 283;
		this.@fixed.HeightRequest = 95;
		this.@fixed.Name = "fixed";
		this.@fixed.HasWindow = false;
		// Container child fixed.Gtk.Fixed+FixedChild
		this.txbInput = new global::Gtk.Entry();
		this.txbInput.WidthRequest = 280;
		this.txbInput.CanFocus = true;
		this.txbInput.Name = "txbInput";
		this.txbInput.IsEditable = true;
		this.txbInput.InvisibleChar = '●';
		this.@fixed.Add(this.txbInput);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.txbInput]));
		w1.X = 24;
		w1.Y = 22;
		// Container child fixed.Gtk.Fixed+FixedChild
		this.btnShowHello = new global::Gtk.Button();
		this.btnShowHello.WidthRequest = 80;
		this.btnShowHello.CanFocus = true;
		this.btnShowHello.Name = "btnShowHello";
		this.btnShowHello.UseUnderline = true;
		this.btnShowHello.Label = global::Mono.Unix.Catalog.GetString("Hello!");
		this.@fixed.Add(this.btnShowHello);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.btnShowHello]));
		w2.X = 130;
		w2.Y = 71;
		this.Add(this.@fixed);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 332;
		this.DefaultHeight = 120;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnShowHello.Pressed += new global::System.EventHandler(this.OnBtnShowHelloPressed);
	}
}
