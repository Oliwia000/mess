using mess.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;



namespace mess.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        
        public ObservableCollection<Dane> Dane { get; set; }

        public MainPageViewModel()
        {
            Dane = new ObservableCollection<Dane>
            {
                new Dane { Id = 1, Name = "Jan Postulski", Description = " Opis : Kawa to moje życie", ImageLink = "osoba1.jpg"},
                new Dane { Id = 2, Name = "Alicja Bystra", Description = " Opis : <brak opisu>", ImageLink = "osoba2.jpg" },
                new Dane { Id = 3, Name = "Adrianna Nowak", Description = " Opis : Przyroda to ciężki przedmiot", ImageLink = "osoba3.jpg" },
                new Dane { Id = 4, Name = "Grażyna Łuk", Description = " Opis : Życie mnie mnie", ImageLink = "osoba4.jpg"},
                new Dane { Id = 5, Name = "Krystian Błąd", Description = " Opis : Life is fun", ImageLink = "osoba5.jpg"},
                new Dane { Id = 6, Name = "Adrian Jańczyk", Description = " Opis : Droga do sukcesu nie jest prosta", ImageLink = "osoba6.jpg"},
                new Dane{ Id = 7, Name = "Michaś Kowalczyk", Description = " Opis : Gry to moja specjalność", ImageLink = "osoba7.jpg"},
            };

        }




        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}