namespace UD3_AppCRUD
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();

            Botonera.Btnanadir.Clicked += Btnanadir_Clicked;
            Botonera.Btnmodificar.Pressed += Btnmodificar_Pressed;
            Botonera.Btnmodificar.Released += Btnmodificar_Released;
            Botonera.BtnEliminar.Focused += BtnEliminar_Focused;
            Botonera.BtnEliminar.Unfocused += BtnEliminar_Unfocused;
        }

        private void BtnEliminar_Unfocused(object? sender, FocusEventArgs e)
        {
            imgCoche.IsVisible = true;
            Botonera.BtnEliminar.Background = Colors.Red;
        }

        private void BtnEliminar_Focused(object? sender, FocusEventArgs e)
        {
           imgCoche.IsVisible = false;
            Botonera.BtnEliminar.Background = Colors.Orange;
        }

        private void Btnmodificar_Released(object? sender, EventArgs e)
        {
            Botonera.Btnmodificar.TextColor = Colors.White;
       
        }

        private void Btnmodificar_Pressed(object? sender, EventArgs e)
        {
            Botonera.Btnmodificar.TextColor = Colors.Red;
        }

        private void Btnanadir_Clicked(object? sender, EventArgs e)
        {
            DisplayAlert("Boton 1 pulsado", "Botón añadir pulsado", "Aceptar");
        }
    }

}
