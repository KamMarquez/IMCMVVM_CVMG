using IMCMVVM_CVMG.ViewsModels;

namespace IMCMVVM_CVMG.Models.Views;

public partial class IMCPage : ContentPage
{
	public IMCPage()
	{
		InitializeComponent();
		//Conecta la pantalla con sus datos y comandos del ViewModel
		BindingContext = new ImcViewModel();
	}
}