
// This file has been generated by the GUI designer. Do not modify.
namespace Sistema
{
	public partial class AsignarEmpleado
	{
		private global::Gtk.Fixed fixed2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview3;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.ComboBox combobox1;

		private global::Gtk.ComboBox combobox2;

		private global::Gtk.Button btnRegresar;

		private global::Gtk.Button button5;

		private global::Gtk.Button button6;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Sistema.AsignarEmpleado
			this.Name = "Sistema.AsignarEmpleado";
			this.Title = global::Mono.Unix.Catalog.GetString("AsignarEmpleado");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Sistema.AsignarEmpleado.Gtk.Container+ContainerChild
			this.fixed2 = new global::Gtk.Fixed();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview3 = new global::Gtk.TreeView();
			this.treeview3.WidthRequest = 400;
			this.treeview3.HeightRequest = 200;
			this.treeview3.CanFocus = true;
			this.treeview3.Name = "treeview3";
			this.GtkScrolledWindow.Add(this.treeview3);
			this.fixed2.Add(this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.GtkScrolledWindow]));
			w2.X = 9;
			w2.Y = 305;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Id Empleado");
			this.fixed2.Add(this.label3);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label3]));
			w3.X = 22;
			w3.Y = 58;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre");
			this.fixed2.Add(this.label4);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label4]));
			w4.X = 24;
			w4.Y = 99;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("\"ID del empleado\"");
			this.fixed2.Add(this.label5);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label5]));
			w5.X = 135;
			w5.Y = 57;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("\"Su nombre\"");
			this.fixed2.Add(this.label6);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label6]));
			w6.X = 105;
			w6.Y = 99;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Departamento");
			this.fixed2.Add(this.label7);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label7]));
			w7.X = 23;
			w7.Y = 141;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo");
			this.fixed2.Add(this.label8);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label8]));
			w8.X = 24;
			w8.Y = 182;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.combobox1 = global::Gtk.ComboBox.NewText();
			this.combobox1.Name = "combobox1";
			this.fixed2.Add(this.combobox1);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.combobox1]));
			w9.X = 140;
			w9.Y = 135;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.combobox2 = global::Gtk.ComboBox.NewText();
			this.combobox2.Name = "combobox2";
			this.fixed2.Add(this.combobox2);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.combobox2]));
			w10.X = 73;
			w10.Y = 176;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.btnRegresar = new global::Gtk.Button();
			this.btnRegresar.CanFocus = true;
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.UseUnderline = true;
			this.btnRegresar.Label = global::Mono.Unix.Catalog.GetString("Regresar");
			this.fixed2.Add(this.btnRegresar);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.btnRegresar]));
			w11.X = 18;
			w11.Y = 533;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button5 = new global::Gtk.Button();
			this.button5.CanFocus = true;
			this.button5.Name = "button5";
			this.button5.UseUnderline = true;
			this.button5.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.fixed2.Add(this.button5);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button5]));
			w12.X = 15;
			w12.Y = 250;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.button6 = new global::Gtk.Button();
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString("Modificar");
			this.fixed2.Add(this.button6);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.button6]));
			w13.X = 110;
			w13.Y = 251;
			this.Add(this.fixed2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 431;
			this.DefaultHeight = 583;
			this.Show();
			this.btnRegresar.Clicked += new global::System.EventHandler(this.OnBtnRegresarClicked);
		}
	}
}
