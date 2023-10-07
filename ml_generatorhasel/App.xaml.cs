using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ml_generatorhasel
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

    }
}