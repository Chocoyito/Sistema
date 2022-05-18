using System;
namespace Sistema
{
    public partial class AsignarEmpleado : Gtk.Window
    {
        public AsignarEmpleado() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnRegresarClicked(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
