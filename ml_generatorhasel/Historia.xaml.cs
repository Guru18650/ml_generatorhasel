using Microsoft.Maui;
using ml_generatorhasel.Resources.Splash;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ml_generatorhasel;

public partial class Historia : ContentPage
{
	public Historia()
	{
		InitializeComponent();
		historyListView.ItemsSource = password_handler.haslaList;
	}
    
    private void delPass_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ViewCell viewCell = (ViewCell)button.Parent.Parent;
        hasloClass selectedItem = (hasloClass)viewCell.BindingContext;
        password_handler.UsunHaslo(selectedItem);
    }

    private async void copyPass_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        ViewCell viewCell = (ViewCell)button.Parent.Parent;
        hasloClass selectedItem = (hasloClass)viewCell.BindingContext;
        await Clipboard.SetTextAsync(selectedItem.haslo);
        var toast = Toast.Make("Skopiowano has³o",ToastDuration.Short, 10);
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        await toast.Show(cancellationTokenSource.Token);
    }
}