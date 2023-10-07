using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ml_generatorhasel.Resources.Splash
{
    public static class password_handler
    {
        public static ObservableCollection<hasloClass> haslaList = new ObservableCollection<hasloClass>();

        static password_handler() {
            haslaList = JsonConvert.DeserializeObject<ObservableCollection<hasloClass>>(Preferences.Get("dane", "[]"));
        }
        public static void DodajHaslo(hasloClass haslo)
        {
            haslaList.Add(haslo);
            Preferences.Set("dane", JsonConvert.SerializeObject(haslaList));
        }

        public static void UsunHaslo(hasloClass haslo)
        {
            haslaList.Remove(haslo);
            Preferences.Set("dane", JsonConvert.SerializeObject(haslaList));
        }
    }
    public class hasloClass
    {
        public string haslo { get; set; }
        public string nazwa { get; set; }
    }
}
