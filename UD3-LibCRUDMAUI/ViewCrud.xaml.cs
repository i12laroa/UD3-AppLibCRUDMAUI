namespace UD3_LibCRUDMAUI;

public partial class ViewCrud : ContentView
{
	public Button Btnanadir => AddButton;

	public Button Btnmodificar { get { return ModifyButton; } }

	public Button BtnEliminar => DeleteButton;

	public ViewCrud()
	{
		InitializeComponent();
	}
}