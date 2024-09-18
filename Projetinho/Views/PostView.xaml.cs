using Projetinho.ViewsModels;

namespace Projetinho.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		BindingContext = new PostViewModels();
		InitializeComponent();
	}
}
