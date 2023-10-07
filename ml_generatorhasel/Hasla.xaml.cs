using ml_generatorhasel.Resources.Splash;

namespace ml_generatorhasel;

public partial class Hasla : ContentPage
{
	public Hasla()
	{
		InitializeComponent();
	}
	public string male = "qwertyuioplkjhgfdsazxcvbnm";
	public string duze = "QWERTYUIOPLKJHGFDSAZXCVBNM";
	public string cyfry = "1234567890";
	public string specjalne = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
	public Random rnd = new Random();
    private async void gen_Clicked(object sender, EventArgs e)
    {
		if(!malelitery.IsChecked && !duzelitery.IsChecked && !liczby.IsChecked && !znakispec.IsChecked) {
			await DisplayAlert("B≥πd", "Zaznacz znaki", "OK");
			return;
		}
		if (string.IsNullOrEmpty(pName.Text) || string.IsNullOrEmpty(pLength.Text))
		{
            await DisplayAlert("B≥πd", "Wprowadü dane", "OK");
            return;
        }
		if(int.Parse(pLength.Text) < 1)
		{
            await DisplayAlert("B≥πd", "Wprowadü poprawne dane", "OK");
            return;
        }
		string letters = "";
		string password = "";
		if (malelitery.IsChecked)
			letters += male;
		if(duzelitery.IsChecked)
			letters += duze;
		if(liczby.IsChecked)
			letters += cyfry;
		if(znakispec.IsChecked)
			letters += specjalne;
        for (int i = 0; i < int.Parse(pLength.Text); i++)
        {
			password += letters[rnd.Next(0, letters.Length)];
        }
		password_handler.DodajHaslo(new hasloClass() { haslo = password, nazwa = pName.Text });
        await Clipboard.SetTextAsync(password);
        await DisplayAlert("Sukces", "Zapisano has≥o na liúcie i skopiowano do schowka","OK");

    }
}